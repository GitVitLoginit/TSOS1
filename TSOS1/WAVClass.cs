using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace TSOS1
{
   public class WAVClass
   {
        private static Random _random = new Random();
        private static int NoizeStep { get { return _random.Next(-1000, 1000); } }

        private class WaveHeader
        {
            public string sGroupID;
            public uint dwFileLength; 
            public string sRiffType; 

            public WaveHeader()
            {
                dwFileLength = 0;
                sGroupID = "RIFF";
                sRiffType = "WAVE";
            }
      
        }

        private class WaveFormatChunk
        {
            public string sChunkID;         // Four bytes: "fmt "
            public uint dwChunkSize;        // Length of header in bytes
            public ushort wFormatTag;       // 1 (MS PCM)
            public ushort wChannels;        // Number of channels
            public uint dwSamplesPerSec;    // Frequency of the audio in Hz... 44100
            public uint dwAvgBytesPerSec;   // for estimating RAM allocation
            public ushort wBlockAlign;      // sample frame size, in bytes
            public ushort wBitsPerSample;    // bits per sample
           

            public WaveFormatChunk()
            {
                sChunkID = "fmt ";
                dwChunkSize = 16;
                wFormatTag = 1;
                wChannels = 1;
                dwSamplesPerSec = 44100;
                wBitsPerSample = 16;
                wBlockAlign = (ushort)(wChannels * (wBitsPerSample / 8));
                dwAvgBytesPerSec = dwSamplesPerSec * wBlockAlign;
            }
        }

        private class WaveDataChunk
        {
            public string sChunkID;     
            public uint dwChunkSize;    
            public short[] shortArray;  

            public WaveDataChunk()
            {
                shortArray = new short[0];
                dwChunkSize = 0;
                sChunkID = "data";
            }

        }

       
        private class WaveGenerator
        {
            WaveHeader header;
            WaveFormatChunk format;
            WaveDataChunk data;
            int Amplitude;
            int Frequency;
            int Phaze;

            public WaveGenerator(Signal type,int amplitude, int frequency, int phaze,bool noize)
            {
                header = new WaveHeader();
                format = new WaveFormatChunk();
                data = new WaveDataChunk();
                double sinValue;
                uint numSamples;
                Amplitude = amplitude;
                Frequency = frequency;
                Phaze = phaze;

                switch (type)
                {
                    case Signal.syn:
                        numSamples = format.dwSamplesPerSec * format.wChannels;
                        data.shortArray = new short[numSamples];

                        double t = (Math.PI * 2 * Frequency) / (format.dwSamplesPerSec * format.wChannels);

                        for (uint i = 0; i < numSamples - 1; i++)
                        {
                            for (int channel = 0; channel < format.wChannels; channel++)
                            {
                                data.shortArray[i + channel] = Convert.ToInt16(Amplitude * Math.Sin(t * i + Phaze));
                                data.shortArray[i + channel] = noize ? Convert.ToInt16(data.shortArray[i + channel] + NoizeStep) : data.shortArray[i + channel];

                            }
                        }
                        data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
                        break;

                    case Signal.rectangle:
                        numSamples = format.dwSamplesPerSec * format.wChannels;
                        data.shortArray = new short[numSamples];

                        for (uint i = 0; i < numSamples - 1; i++)
                        {
                            for (int channel = 0; channel < format.wChannels; channel++)
                            {
                                sinValue = (2 * Math.PI * Frequency)/(format.dwSamplesPerSec * format.wChannels);
                                data.shortArray[i + channel] = Convert.ToInt16(amplitude * Math.Sign(Math.Sin((i * sinValue + phaze))));
                                data.shortArray[i + channel] = noize ? Convert.ToInt16(data.shortArray[i + channel] + NoizeStep) : data.shortArray[i + channel];
                            }
                        }
                        data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
                        break;

                    case Signal.triangle:
                        numSamples = format.dwSamplesPerSec * format.wChannels;
                        data.shortArray = new short[numSamples];

                        for (uint i = 0; i < numSamples - 1; i++)
                        {
                            for (int channel = 0; channel < format.wChannels; channel++)
                            {

                                sinValue = (2 * Math.PI * Frequency) / (format.dwSamplesPerSec * format.wChannels);
                                data.shortArray[i + channel] = Convert.ToInt16(amplitude * Math.Asin(Math.Sin((i * sinValue + phaze))));
                                data.shortArray[i + channel] = noize ? Convert.ToInt16(data.shortArray[i + channel] + NoizeStep) : data.shortArray[i + channel];
                            }
                        }
                        data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
                        break;

                    case Signal.saw:
                        numSamples = format.dwSamplesPerSec * format.wChannels;
                        data.shortArray = new short[numSamples];

                        for (uint i = 0; i < numSamples - 1; i++)
                        {
                            for (int channel = 0; channel < format.wChannels; channel++)
                            {

                                sinValue = (Math.PI * Frequency) / (format.dwSamplesPerSec * format.wChannels);
                                data.shortArray[i + channel] = Convert.ToInt16(-2*amplitude/Math.PI * Math.Atan(1/Math.Tan((i * sinValue + phaze))));
                                data.shortArray[i + channel] = noize ? Convert.ToInt16(data.shortArray[i + channel] + NoizeStep) : data.shortArray[i + channel];
                            }
                        }
                        data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
                        break;
                }
            }
            public void SaveWAV(string filePath)
            {

                FileStream fileStream = new FileStream(filePath, FileMode.Create);

                BinaryWriter writer = new BinaryWriter(fileStream);

                writer.Write(header.sGroupID.ToCharArray());

                writer.Write(header.dwFileLength);

                writer.Write(header.sRiffType.ToCharArray());

                writer.Write(format.sChunkID.ToCharArray());

                writer.Write(format.dwChunkSize);

                writer.Write(format.wFormatTag);

                writer.Write(format.wChannels);

                writer.Write(format.dwSamplesPerSec);

                writer.Write(format.dwAvgBytesPerSec);

                writer.Write(format.wBlockAlign);

                writer.Write(format.wBitsPerSample);


                writer.Write(data.sChunkID.ToCharArray());

                writer.Write(data.dwChunkSize);

                foreach (short dataPoint in data.shortArray)
                {
                    writer.Write(dataPoint);
                }

                writer.Seek(4, SeekOrigin.Begin);

                uint filesize = (uint)writer.BaseStream.Length;

                writer.Write(filesize - 8);


                writer.Close();

                fileStream.Close();
                

            }
        }

     public void Save(Signal signalType,int amplitude,int frequency,int phaze,bool noize)
     {
            
            WaveGenerator waveGenerator = new WaveGenerator(signalType, amplitude, frequency, phaze, noize);

            waveGenerator.SaveWAV(@"This.WAV");
                   
     }
       
    }
}
