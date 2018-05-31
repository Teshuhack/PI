using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics gr;
        Random rnd = new Random();
        List<double> X;
        List<double> Y;
        List<double> XCircle;
        List<double> YCircle;
        int pointsCount, scale;
        double circlePts;
        bool isLoaded;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            scale = 300;
            isLoaded = true;
            tslCircle.Text += 0;
            tslSquare.Text += 0;
            tslPI.Text += 0;
            gr = drawPanel.CreateGraphics();
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 10; i < drawPanel.Width; i += 10)
            {
                gr.DrawLine(Pens.Aqua, new Point(0, i), new Point(drawPanel.Width, i));
                gr.DrawLine(Pens.Aqua, new Point(i, 0), new Point(i, drawPanel.Height));
            }

            gr.DrawEllipse(Pens.Black, new Rectangle(1, 1, drawPanel.Width - 3, drawPanel.Height - 3));
            gr.DrawRectangle(Pens.Black, new Rectangle(0, 0, drawPanel.Width - 1, drawPanel.Height - 1));
        }

        private void tsbDrawPts_Click(object sender, EventArgs e)
        {
            pointsCount = rnd.Next(100001);

            X = new List<double>();
            Y = new List<double>();

            if (!isLoaded)
            {
                drawPanel.Refresh();
            }

            for (int i = 0; i < pointsCount; i++)
            {
                X.Add(2 * rnd.NextDouble());
                Y.Add(2 * rnd.NextDouble());
                gr.DrawEllipse(Pens.Blue, new RectangleF((float)X[i] * scale, (float)Y[i] * scale, 1, 1));
            }

            isLoaded = false;

            tsbRecognize.Enabled = true;
            tsbDrawPts.Enabled = false;

            tslSquare.Text = string.Format("Square points: {0}", pointsCount);
            tslCircle.Text = string.Format("Cirlce points: {0}", 0);
        }

        private void tsbRecognize_Click(object sender, EventArgs e)
        {
            XCircle = new List<double>();
            YCircle = new List<double>();

            for (int i = 0; i < pointsCount; i++)
            {
                if ((Math.Sqrt(Math.Pow(X[i] - 1, 2) + Math.Pow(Y[i] - 1, 2))) < 1)
                {
                    XCircle.Add(X[i]);
                    YCircle.Add(Y[i]);
                    circlePts++;
                }
            }

            for (int i = 0; i < circlePts; i++)
            {
                gr.DrawEllipse(Pens.Green, new RectangleF((float)XCircle[i] * scale, (float)YCircle[i] * scale, 2, 2));
            }

            tsbCalculate.Enabled = true;
            tsbDrawPts.Enabled = false;
            tsbRecognize.Enabled = false;

            tslCircle.Text = string.Format("Circle points: {0}", circlePts);
        }

        private void tsbCalculate_Click(object sender, EventArgs e)
        {
            double pi = 4 * circlePts / pointsCount;

            tslPI.Text = pi.ToString();

            tsbCalculate.Enabled = false;
            tsbDrawPts.Enabled = true;

            circlePts = 0;
            X.Clear();
            Y.Clear();
            XCircle.Clear();
            YCircle.Clear();
        }
    }
}
