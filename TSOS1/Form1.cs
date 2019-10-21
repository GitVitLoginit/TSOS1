using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using ZedGraph;

namespace TSOS1
{
    public partial class Form1 : Form
    {
        private static double inc = 1;
        private static double scal = 500;
        private static Random _random = new Random();
        private static int NoizeStep { get {return _random.Next(-10, 10); } }

        private SoundPlayer SoundPlayer = new SoundPlayer(@"This.WAV");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ZedGraphControl zedGraph = zedGraphControl1;
            radioButtonFrequency.Checked = true;

            comboBoxSignals.SelectedIndex = 0; 
            zedGraph.Name = "Graphic";
            SetParams(zedGraph);
        }

        private void CreateField()
        {
            DrawGraph(zedGraphControl1);
        }

        private void DrawGraph(ZedGraphControl zgc)
        {
            WAVClass wAV;

            var N = 4096;
            var amplitude = (int)numericAmplitude.Value;
            var phase  = (int)numericPhaze.Value;
            var frequency = (int)numericFreqiency.Value;
            var signal = (Signal)comboBoxSignals.SelectedIndex;

            PointPairList pointPair = ComputePoints(amplitude,phase,frequency,N, signal);

            GraphPane myPane = zgc.GraphPane;

            zgc.AxisChange();
            zgc.Refresh();
            zgc.GraphPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve(signal.ToString(),
               pointPair, Color.Blue, SymbolType.None);

            zgc.AxisChange();
            zgc.Refresh();

            wAV = new WAVClass();
            try
            {
                wAV.Save(signal, amplitude, frequency, phase,checkBoxNoize.Checked);
            }
            catch (Exception) { }
            
        }

        private  PointPairList ComputePoints (double amplitude, double phase, double frequency, int N, Signal signal, PointPairList synPoints =null)
        {
            PointPairList pairList = new PointPairList();


            switch (signal)
            {
                case Signal.syn:
                    {
                        return GetPointsForSyn(pairList, amplitude, phase, frequency, N);
                    }
                case Signal.saw:
                    {
                        return GetPointsForSaw(pairList, amplitude, phase, frequency, N);
                    }
                case Signal.triangle:
                    {
                        return GetPointsForTriangle(pairList, amplitude, phase, frequency, N);
                    }
                case Signal.rectangle:
                    {
                        return GetPointsForRectangle(pairList, amplitude, phase, frequency, N);
                    }
                case Signal.SinRect:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N,Signal.syn,Signal.rectangle);
                    }
                case Signal.SinSaw:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N, Signal.syn, Signal.saw);
                    }
                case Signal.SinTriangle:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N, Signal.syn, Signal.triangle);
                    }
                case Signal.SawRect:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N,Signal.saw,Signal.rectangle);
                    }
                case Signal.SinRectSaw:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N, Signal.syn, Signal.rectangle,Signal.saw);
                    }
                case Signal.RectTriangleSaw:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N, Signal.rectangle, Signal.triangle, Signal.saw);
                    }
                case Signal.SinRectTriangleSaw:
                    {
                        return GetPointsForPoliSignal(pairList, amplitude, phase, frequency, N, Signal.syn, Signal.rectangle, Signal.triangle, Signal.saw);
                    }
            }
            return null;
        }

        private  PointPairList GetPointsForSyn(PointPairList pairList, double amplitude, double phase, double frequency, int N)
        {
            //PointPairList pairList2 = new PointPairList();
            ////GetPointsForPoliSyn(pairList2,amplitude, phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            //GetPointsForPoliSyn(pairList2, Int32.Parse(Amplitude2.Value.ToString()), phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            PointPairList pairList2 = new PointPairList();
            //GetPointsForPoliSyn(pairList2,amplitude, phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            GetPointsForRectangle(pairList2, Int32.Parse(Amplitude2.Value.ToString()), phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                amplitude = pairList2[index].Y;
                var length = (2 * Math.PI * frequency * index) / N;
                var lengthWihPhase = length + phase;
                var sin = Math.Sin(lengthWihPhase);
                var y = amplitude * sin;
                y = noize ? y + NoizeStep : y;
                pairList.Add(index, y);
                //amplitude = UpdateValue(amplitude, parameter.amp);
                //phase = UpdateValue(phase, parameter.phase);
                //frequency = UpdateValue(frequency, parameter.fre);
            }



            return pairList;
        }

        private PointPairList GetPointsForPoliSyn(PointPairList pairList, double amplitude, double phase, double frequency, int N)
        {
            var noize = checkBoxNoize.Checked;
            for (var index = 0; index <= N; index++)
            {
               
                var length = (2 * Math.PI * frequency * index) / N;
                var lengthWihPhase = length + phase;
                var sin = Math.Sin(lengthWihPhase);
                var y = amplitude * sin;
                y = noize ? y + NoizeStep : y;
                pairList.Add(index, y);
                //amplitude = UpdateValue(amplitude, parameter.amp);
                //phase = UpdateValue(phase, parameter.phase);
                //frequency = UpdateValue(frequency, parameter.fre);
            }
            return pairList;
        }

        private PointPairList GetPointsForPoliSignal(PointPairList pairList, double amplitude, double phase, double frequency, int N, Signal firstSignal, Signal secondSignal, Signal? thirdSignal=null, Signal? fourthSignal = null)
        {
            var noize = checkBoxNoize.Checked;

            var first = ComputePoints(amplitude, phase, frequency, N, firstSignal);

            if (radioButtonFrequency.Checked)
            {
                var second = ComputePoints(amplitude, phase, (Int32.Parse(SecondFrequency.Value.ToString())), N, secondSignal);

                if (thirdSignal == null)
                {
                    for (var index = 0; index <= N; index++)
                    {
                        first[index].Y = first[index].Y + second[index].Y;
                    }
                    return first;
                }
                var third = ComputePoints(amplitude, phase, (Int32.Parse(ThirdFrequency.Value.ToString())), N, thirdSignal.Value);

                for (var index = 0; index <= N; index++)
                {
                    first[index].Y = first[index].Y + second[index].Y + third[index].Y;
                }

                if (fourthSignal != null)
                {
                    var fourth = ComputePoints(amplitude, phase, (Int32.Parse(FourthFrequency.Value.ToString())), N, fourthSignal.Value);

                    for (var index = 0; index <= N; index++)
                    {
                        first[index].Y = first[index].Y + fourth[index].Y;
                    }

                    return first;
                }
            }
            else
            {
                var second = ComputePoints((Int32.Parse(Amplitude2.Value.ToString())), phase, frequency, N, secondSignal);

                if (thirdSignal == null)
                {
                    for (var index = 0; index <= N; index++)
                    {
                        first[index].Y = first[index].Y + second[index].Y;
                    }
                    return first;
                }
                var third = ComputePoints((Int32.Parse(Amplitude3.Value.ToString())), phase, frequency, N, thirdSignal.Value);

                for (var index = 0; index <= N; index++)
                {
                    first[index].Y = first[index].Y + second[index].Y + third[index].Y;
                }

                if (fourthSignal != null)
                {
                    var fourth = ComputePoints((Int32.Parse(Amplitude4.Value.ToString())), phase, frequency, N, fourthSignal.Value);

                    for (var index = 0; index <= N; index++)
                    {
                        first[index].Y = first[index].Y + fourth[index].Y;
                    }

                    return first;
                }

            }
            //for (var index = 0; index <= N; index++)
            //{
            //    double sum = 0;

            //    for (var y1 = 1; y1 <= 5; y1++)
            //    {
            //        var first = Math.Pow(-1, y1 + 1)/y1;
            //        var second = first * Math.Sin(((2 * Math.PI * index) * frequency ));


            //        sum += amplitude*second;
            //    }
            //    var third = (2 / Math.PI) * sum;
            //    pairList.Add(index, third);
            //}


            return first;
        }

            
        private  PointPairList GetPointsForSaw(PointPairList pairList, double amplitude, double phase, double frequency, int N)
        {
            PointPairList pairList2 = new PointPairList();
            //GetPointsForPoliSyn(pairList2,amplitude, phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            GetPointsForPoliSyn(pairList2, Int32.Parse(Amplitude2.Value.ToString()), phase, Int32.Parse(SecondFrequency.Value.ToString()), N);


            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                var period = (1 / frequency) * scal;
                amplitude = pairList2[index].Y;
                var first = (-2*amplitude)/Math.PI;// (2 * amplitude / Math.PI);
                var arcTan = Math.Atan(1/(Math.Tan(index*Math.PI/period + phase))); //Math.Asin(Math.Sin(2 * Math.PI * index * frequency));
                var second = first * arcTan;
                second = noize ? second + NoizeStep : second;
                pairList.Add(index, second);
            }
            return pairList;
        }

        private  PointPairList GetPointsForRectangle(PointPairList pairList, double amplitude, double phase, double frequency, int N)
        {
            //PointPairList pairList2 = new PointPairList();
            ////GetPointsForPoliSyn(pairList2,amplitude, phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            //GetPointsForPoliSyn(pairList2, Int32.Parse(Amplitude2.Value.ToString()), phase, Int32.Parse(SecondFrequency.Value.ToString()), N);

            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                //amplitude = pairList2[index].Y;
                var period = (1 / frequency) * scal;

                var arcTan = amplitude* Math.Sign(Math.Sin(2 * Math.PI * index / period + phase)); //Math.Asin(Math.Sin(2 * Math.PI * index * frequency));

                arcTan = noize ? arcTan + NoizeStep : arcTan;
                pairList.Add(index, arcTan);
            }
            return pairList;
        }


        private  PointPairList GetPointsForTriangle(PointPairList pairList, double amplitude, double phase, double frequency, int N)
        {
            PointPairList pairList2 = new PointPairList();
           //  GetPointsForPoliSyn(pairList2, amplitude/5, phase, Int32.Parse(SecondFrequency.Value.ToString()), N);
            GetPointsForPoliSyn(pairList2, Int32.Parse(Amplitude2.Value.ToString()), phase,frequency, N);

            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                amplitude = pairList2[index].Y;
                var period = (1 / frequency) *10000;

                var first = amplitude * Math.Asin(Math.Sin(2*Math.PI*index/period + phase))/Math.PI;// (2 * amplitude / Math.PI);


                first = noize ? first + NoizeStep : first;
                pairList.Add(index, first);
            }
            return pairList;
        }

        private  void SetParams(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;
            // Set the titles and axis labels
            myPane.Title.Text = "Axis Cross Demo";
            myPane.XAxis.Title.Text = "My X Axis";
            myPane.YAxis.Title.Text = "My Y Axis";
            // Set the Y axis intersect the X axis at an X value of 0.0
            myPane.YAxis.Cross = 0.0;
            // Turn off the axis frame and all the opposite side tics
            myPane.Chart.Border.IsVisible = false;
            myPane.YAxis.Scale.Min = -200;
            myPane.YAxis.Scale.Max = 200;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 200;
            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
            zgc.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateField();
        }
     

        private void phazeBar_ValueChanged(object sender, EventArgs e)
        {
            CreateField();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SoundPlayer.Stop();
            SoundPlayer.PlayLooping();
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer.Stop();
        }

        private void comboBoxSignals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
