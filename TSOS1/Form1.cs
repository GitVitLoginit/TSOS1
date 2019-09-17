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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSettingsMode1.DataSource = new List<string>() {"Амплитуда и частота потоянные", "Начальная фаза и частота потоянные", "Начальная фаза и амплитуда потоянные" };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Pen myPen = new Pen(Color.Red);
            //g.Transform = new System.Drawing.Drawing2D.Matrix(1,0,0,-1,0,this.ClientRectangle.Height);
            //g.DrawLine(myPen, this.ClientRectangle.Left, this.ClientRectangle.Top, this.ClientRectangle.Right, this.ClientRectangle.Bottom);


     

        }

        private  void CreateField()
        {
            var serviceX = 300;


            ZedGraphControl zedGraph = new ZedGraphControl();

            zedGraph.Location = new System.Drawing.Point(0, 0);
            zedGraph.Name = "zedGraph";
            zedGraph.Size = new System.Drawing.Size(this.ClientRectangle.Right-serviceX, this.ClientRectangle.Bottom);
            this.Controls.Add(zedGraph);
            CreateGraph(zedGraph);
        }

            private static void CreateGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;
            // Set the titles and axis labels
            myPane.Title.Text = "Axis Cross Demo";
            myPane.XAxis.Title.Text = "My X Axis";
            myPane.YAxis.Title.Text = "My Y Axis";

            // Make up some data arrays based on the Sine function
            double x, y;
            PointPairList list = new PointPairList();
            list.Add(new PointPair(10,10));
            list.Add(new PointPair(100, 100));
            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve("Parabola",
               list, Color.Black, SymbolType.Default);
            
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

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
        }


        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            
            label3.Text = trackBar3.Value.ToString();
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
    }
}
