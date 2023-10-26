using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num = 100;
            //double xmin = 0, xmax = 10, ymin = 0, ymax = 10;
            //int n = 0;
            //double x, y;

            //// Area of circle
            //double areaSquare = (ymax - ymin) * (xmax - xmin);
            //double areaCircle = 0;
            //double actualArea;

            //Random obj = new Random();

            //for (int i = 0; i < num; i++)
            //{
            //    x = xmin + (xmax - xmin) * obj.NextDouble();
            //    y = ymin + (ymax - ymin) * obj.NextDouble();

            //    if ((x * x + y * y) <= ((xmax / 2) * (xmax / 2)))
            //    {
            //        n = n + 1;
            //    }
            //    if ((x * x + y * y) <= ((ymax / 2) * (ymax / 2)))
            //    {
            //        n = n + 1;
            //    }
            //}
            //areaCircle = (double)n/(double)num * areaSquare;
            ////actualArea = (3.14 * x * x) + (3.14 * y * y);

            //textBox1.Text = areaCircle.ToString();
            ////textBox2.Text = actualArea.ToString();

            //int np = 1000;
            //float xmin = 0, xmax = 10, ymin = 0, ymax = 10;
            //int n = 1;
            //float areasq = (ymax - ymin) * (xmax - xmin);
            //float areacir = 0, x, y;

            //Random rnd = new Random();

            //Graphics gg = CreateGraphics();
            //SolidBrush sb = new SolidBrush(Color.Red);
            //SolidBrush sb1 = new SolidBrush(Color.Blue);

            ////float x1 = float.Parse(textBox1.Text);
            ////float x2 = float.Parse(textBox2.Text);

            //for (int i = 0; i < np; i++)
            //{
            //    x = xmin + (xmax - xmin) * (float)rnd.NextDouble();
            //    y = ymin + (ymax - ymin) * (float)rnd.NextDouble();

            //    if ((x * x + y * y) <= ((xmax / 2) * (xmax / 2)))
            //    {
            //        n++;
            //        gg.FillEllipse(sb, 100 - x * 10, 200 + y * 10, 5, 5);
            //    }
            //    if ((x * x + y * y) <= ((ymax / 2) * (ymax / 2)))
            //    {
            //        n++;
            //        gg.FillEllipse(sb1, 100 - x * 10, 200 + y * 10, 5, 5);
            //    }
            //}

            //areacir = (float)(n / np) * areasq;
            ////textBox1.Text = areacir.ToString();
            //MessageBox.Show("the absolutue error is =" + areacir);

            //this.Refresh();
            //// THIS DIStance is parallel to x axis
            //float x1 = float.Parse(textBox1.Text);
            //float x2 = float.Parse(textBox2.Text);
            //float actualDistance = x2 - x1;
            //float randomd; double r;
            //float xmin = x1 - 10, xmax = x2 + 10;
            //int n = 100, n1 = 0;
            //Random obj = new Random();
            //Graphics gg = CreateGraphics();
            //SolidBrush rb = new SolidBrush(Color.Red);
            //SolidBrush bb = new SolidBrush(Color.Blue);
            //for (int i = 0; i < n; i++)
            //{
            //    r = xmin + (xmax - xmin) * obj.NextDouble();
            //    if (r >= x1 && r <= x2)
            //    {
            //        n1++;
            //        gg.FillEllipse(rb, 200 + (float)r * 5, 400, 5, 5);
            //    }
            //    else
            //    {
            //        gg.FillEllipse(bb, 200 + (float)r * 5, 400, 5, 5);
            //    }
            //    Thread.Sleep(2);
            //    textBox3.Text = "counter=" + (i++);
            //    textBox3.Refresh();
            //}
            //randomd = (float)n1 / (float)n * (xmax - xmin);
            //float error = Math.Abs(actualDistance - randomd);
            //MessageBox.Show("the absolutue error is =" + error);

            //int np = 10000;
            //float xmin = 0, xmax = 10, ymin = 0, ymax = 10;
            //int n = 1;
            //float areasq = (ymax - ymin) * (xmax - xmin);
            //float areacir = 0, x, y;

            //Random rnd = new Random();

            //Graphics gg = CreateGraphics();
            //SolidBrush sb = new SolidBrush(Color.Red);
            //SolidBrush sb1 = new SolidBrush(Color.Blue);

            //for (int i = 0; i < np; i++)
            //{
            //    x = xmin + (xmax - xmin) * (float)rnd.NextDouble();
            //    y = ymin + (ymax - ymin) * (float)rnd.NextDouble();

            //    if ((x - 5) * (x - 5) + (y - 5) * (y - 5) <= 25) // check if point is inside the circle
            //    {
            //        gg.FillEllipse(sb, 200 - x * 20, 200 + y * 20, 5, 5);
            //        n++;
            //    }
            //    else
            //    {
            //        gg.FillEllipse(sb1, 200 - x * 20, 200 + y * 20, 5, 5);
            //    }
            //}

            //areacir = (float)(n / np * areasq * Math.PI / 4); // calculate the area of the circle
            //float areasquare = areasq - areacir; // calculate the area of the square

            //MessageBox.Show("Area of square: " + areasq.ToString() +
            //    "\nArea of circle: " + areacir.ToString() + 
            //    "\nAbsolute error: " + Math.Abs(Math.PI * 5 * 5 - areacir).ToString());


            int np = 10000;
            float xmin = 0, xmax = 20, ymin = 0, ymax = 20;
            int n = 0;
            float areasq = (ymax - ymin) * (xmax - xmin);
            float areacir = 0, x, y;

            Random rnd = new Random();

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(Color.Blue);

            for (int i = 0; i < np; i++)
            {
                x = xmin + (xmax - xmin) * (float)rnd.NextDouble();
                y = ymin + (ymax - ymin) * (float)rnd.NextDouble();

                if (((x - (xmax / 2)) * (x - (xmax / 2)) + (y - (ymax / 2)) * (y - (ymax / 2))) 
                    <= ((xmax/2) * (ymax/2)))
                // check if point is inside the circle
                {
                    gg.FillEllipse(sb, 500 - x * 20, 200 + y * 20, 5, 5);
                    n++;
                }
                else
                {
                    gg.FillEllipse(sb1, 500 - x * 20, 200 + y * 20, 5, 5);
                   // n++;
                }
            }

            areacir = (float)(n) / (float)(np) * areasq ; // calculate the area of the circle
            float areasquare = areasq - areacir; // calculate the area of the square

            MessageBox.Show("Area of square: " + areasq.ToString() +
                "\nArea of circle: " + areacir.ToString() +
                "\nAbsolute error: " + Math.Abs( Math.PI* xmax/2 * ymax/2 - areacir).ToString());

        }
    }
}
