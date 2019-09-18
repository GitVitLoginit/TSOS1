﻿using PdfSharp.Drawing;
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
            SetParams(zgc);

            var N = 512;
            var amplitude = (int)numericAmplitude.Value;
            var phase  = (int)numericPhaze.Value;
            var frequency = (int)numericFreqiency.Value;

            PointPairList synPairs = ComputePoints(amplitude,phase,frequency,N,Signal.syn);

            PointPairList drawPairs = ComputePoints(amplitude, phase, frequency, N, Signal.saw, synPairs);

            GraphPane myPane = zgc.GraphPane;


            // Make up some data arrays based on the Sine function

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            zgc.GraphPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("Parabola",
               drawPairs, Color.Black, SymbolType.None);
            
      
        }

        private static PointPairList ComputePoints (double amplitude, double phase, double frequency, double N, Signal signal, PointPairList synPoints =null)
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
            }
            return null;
        }

        private static PointPairList GetPointsForSyn(PointPairList pairList, double amplitude, double phase, double frequency, double N)
        {
            for (var index = 0; index <= N; index++)
            {
                var first = (2 * Math.PI * phase * index) / N + phase;
                var second = amplitude * Math.Sin(first);

                pairList.Add(index, second);
            }
            return pairList;
        }

        private static PointPairList GetPointsForSaw(PointPairList pairList, double amplitude, double phase, double frequency, double N, PointPairList synPoints)
        {
            for (var index = 0; index <= N; index++)
            {
                //var first = Math.Pow(-1,index+1)/index * Math.Sin(index * DoubleList[index])*30 *2/Math.PI;
                double sumresult = 0;
                double period = (1 / frequency);
                for (var y = 1; y <= 30; y++)
                {
                    sumresult += 1/y * Math.Sin((y * 2 * Math.PI )/ (period * index));
                }
                var result = (synPoints[index].Y / 2 - synPoints[index].Y / Math.PI)*sumresult;

                pairList.Add(index, result);
            }
            return pairList;
        }

        private static PointPairList GetPointsForRectangle(PointPairList pairList, double amplitude, double phase, double frequency, double N, PointPairList synPoints)
        {
            for (var index = 0; index <= N; index++)
            {
                //var first = Math.Pow(-1,index+1)/index * Math.Sin(index * DoubleList[index])*30 *2/Math.PI;
                double sumresult = 0;
                double period = (1 / frequency);
                for (var y = 1; y <= 30; y+=2)
                {
                    sumresult += Math.Sin((((2 * Math.PI)/frequency)*index)/y);
                }
                var result =((4* synPoints[index].Y) / Math.PI)*sumresult;

                pairList.Add(index, result);
            }
            return pairList;
        }


        private static void SetParams(ZedGraphControl zgc)
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
            myPane.YAxis.Scale.Min = -100;
            myPane.YAxis.Scale.Max = 100;
            myPane.XAxis.Scale.Min = -100;
            myPane.XAxis.Scale.Max = 100;
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
