using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VEditor
{
    public partial class Form1 : Form
    {
        private bool mouseDown = false;
        private List<Line> arrayLines;
        Point[][] points;
        Color color;
        float wight;
       // Bitmap map = new Bitmap(256, 256);
        Graphics graphics;
        //Pen pen;

        public Form1()
        {
            InitializeComponent();
            arrayLines = new List<Line>();
            points = new Point[1][];
            points[0] = new Point[2];

            color = Color.Black;
            wight = 1;
           // pen = new Pen(Color.Black, wight);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            //arrayPoints[0] = e.X;
            //arrayPoints[1] = e.Y;

            points[0][0].X = e.X;
            points[0][0].Y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            //arrayPoints[3] = e.X;
            //arrayPoints[4] = e.Y;
            points[0][1].X = e.X;
            points[0][1].Y = e.Y;

            arrayLines.Add(new Line(points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y, color, wight));
            panel1.Invalidate();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown) 
            {
                points[0][1].X = e.X;
                points[0][1].Y = e.Y;
                panel1.Invalidate();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            if (mouseDown)
            {
                graphics.DrawLine(new Pen(color, wight), points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y);

            }

            if (arrayLines.Count > 0)
            {
               foreach(Line line in arrayLines)
                {
                    graphics.DrawLine(new Pen(line.getColor(), line.getWigth()), line.getX1(), line.getY1(), line.getX2(), line.getY2());
                }
            }
 

        }

        private void color1_Click(object sender, EventArgs e)
        {
           // pen.Color = ((Button)sender).BackColor;
            color = ((Button)sender).BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;

            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           // pen.Width = trackBar1.Value;
            wight = trackBar1.Value;
        }
    }
}
