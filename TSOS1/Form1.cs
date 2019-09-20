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
using ZedGraph;

namespace TSOS1
{
    public partial class Form1 : Form
    {
        private static Random _random = new Random();
        private static int NoizeStep { get {return _random.Next(-40, 40); } }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSettingsMode1.DataSource = new List<string>() {"Амплитуда и частота потоянные", "Начальная фаза и частота потоянные", "Начальная фаза и амплитуда потоянные" };

            ZedGraphControl zedGraph = zedGraphControl1;

            zedGraph.Location = new System.Drawing.Point(0, 0);
            zedGraph.Name = "zedGraph";
            SetParams(zedGraph);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Pen myPen = new Pen(Color.Red);
            //g.Transform = new System.Drawing.Drawing2D.Matrix(1,0,0,-1,0,this.ClientRectangle.Height);
            //g.DrawLine(myPen, this.ClientRectangle.Left, this.ClientRectangle.Top, this.ClientRectangle.Right, this.ClientRectangle.Bottom);    

        }

        private void CreateField()
        {
            DrawGraph(zedGraphControl1);
        }

            private void DrawGraph(ZedGraphControl zgc)
        {        

            var N = 4096;
            var amplitude = (int)numericAmplitude.Value;
            var phase  = (int)numericPhaze.Value;
            var frequency = (int)numericFreqiency.Value;

            PointPairList synPairs = ComputePoints(amplitude,phase,frequency,N,Signal.syn);

            PointPairList sawPairs = ComputePoints(amplitude, phase, frequency, N, Signal.saw, synPairs);

            PointPairList trianglePairs = ComputePoints(amplitude, phase, frequency, N, Signal.triangle);

            PointPairList recPairs = ComputePoints(amplitude, phase, frequency, N, Signal.rectangle);

            GraphPane myPane = zgc.GraphPane;


            // Make up some data arrays based on the Sine function

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            zgc.AxisChange();
            zgc.Refresh();
            zgc.GraphPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("Parabola",
               synPairs, Color.Blue, SymbolType.None);
            
      
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
                        return GetPointsForSaw(pairList, amplitude, phase, frequency, N,synPoints);
                    }
                case Signal.triangle:
                    {
                        return GetPointsForTriangle(pairList, amplitude, phase, frequency, N, synPoints);
                    }
                case Signal.rectangle:
                    {
                        return GetPointsForRectangle(pairList, amplitude, phase, frequency, N, synPoints);
                    }
            }
            return null;
        }

        private  PointPairList GetPointsForSyn(PointPairList pairList, double amplitude, double phase, double frequency, int N)
        {
            var noize = checkBoxNoize.Checked;
                       //for (var index = 0; index <= N; index++)
            //{
            //    var length = (2 * Math.PI * frequency * index) / N ;
            //    var lengthWihPhase = length + phase;
            //    var sin = Math.Sin(lengthWihPhase);
            //    var second = amplitude * sin;

            //    pairList.Add(index, second);
            //}
            //return pairList;

            for (var index = 0; index <= N; index++)
            {
                var length = (2 * Math.PI * frequency * index) / N;
                var lengthWihPhase = length + phase;
                var sin = Math.Sin(lengthWihPhase);
                var y = amplitude * sin;
                y = noize ? y + NoizeStep : y;
                pairList.Add(index, y);
            }
            return pairList;
        }

        private  PointPairList GetPointsForSaw(PointPairList pairList, double amplitude, double phase, double frequency, int N, PointPairList synPoints)
        {
            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                var period = (1 / frequency)*200;
                var first = (-2*amplitude)/Math.PI;// (2 * amplitude / Math.PI);
                var arcTan = Math.Atan(1/(Math.Tan(index*Math.PI/period))); //Math.Asin(Math.Sin(2 * Math.PI * index * frequency));
                var second = first * arcTan;
                second = noize ? second + NoizeStep : second;
                pairList.Add(index, second);
            }
            return pairList;
        }

        private  PointPairList GetPointsForRectangle(PointPairList pairList, double amplitude, double phase, double frequency, int N, PointPairList synPoints)
        {
            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                var period = (1 / frequency) * 300;
                var arcTan = amplitude* Math.Sign(Math.Sin(2 * Math.PI * index / period)); //Math.Asin(Math.Sin(2 * Math.PI * index * frequency));

                arcTan = noize ? arcTan + NoizeStep : arcTan;
                pairList.Add(index, arcTan);
            }
            return pairList;
        }


        private  PointPairList GetPointsForTriangle(PointPairList pairList, double amplitude, double phase, double frequency, int N, PointPairList synPoints)
        {
            var noize = checkBoxNoize.Checked;

            for (var index = 0; index <= N; index++)
            {
                var period = (1 / frequency)*200;
                var first = amplitude * Math.Asin(Math.Sin(2*Math.PI*index/period))/Math.PI;// (2 * amplitude / Math.PI);


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

        private void trackBar7_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = trackBar7.Value.ToString();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = trackBar4.Value.ToString();
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = trackBar5.Value.ToString();
        }

        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = trackBar6.Value.ToString();
        }

        private void phazeBar_ValueChanged(object sender, EventArgs e)
        {
            CreateField();
        }
     
    }
}
