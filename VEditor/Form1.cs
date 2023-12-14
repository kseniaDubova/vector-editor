using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
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
        Color color, old_color;
        float wight, old_wight;
        int catch_line_index;
        bool point_focused;
        int catch_point_index;
        // Bitmap map = new Bitmap(256, 256);
        Graphics graphics;
        string mode;

        public Form1()
        {
            InitializeComponent();
            arrayLines = new List<Line>();
            points = new Point[1][];
            points[0] = new Point[2];
            string[] listSize = {"1", "5", 
                "10", "15", "20", "25", "30"};
            SizeList.Items.AddRange(listSize);
            color = Color.Black;
            wight = 1;
            old_color = Color.Black;
            old_wight = 1;
            point_focused = false;
            catch_line_index = -1;
            catch_point_index = -1;
            mode = "line";
        }
     

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            if (mode == "line")
            {
                points[0][0].X = e.X;
                points[0][0].Y = e.Y;
            }
            if (mode == "change")
            {

                old_color = arrayLines[catch_line_index].getColor();
                old_wight = arrayLines[catch_line_index].getWigth();
                
                if (catch_point_index == 1)
                {
                    points[0][0].X = (int)arrayLines[catch_line_index].getX2();
                    points[0][0].Y = (int)arrayLines[catch_line_index].getY2();
                    points[0][1].X = e.X;
                    points[0][1].Y = e.Y;
                }
                if (catch_point_index == 2)
                {
                    points[0][0].X = (int)arrayLines[catch_line_index].getX1();
                    points[0][0].Y = (int)arrayLines[catch_line_index].getY1();
                    points[0][1].X = e.X;
                    points[0][1].Y = e.Y;
                }
                arrayLines.Remove(arrayLines[catch_line_index]);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            points[0][1].X = e.X;
            points[0][1].Y = e.Y;
            if (mode == "line")
            {
                arrayLines.Add(new Line(points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y, color, wight));
            }

            if (mode == "change")
            {
                arrayLines.Add(new Line(points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y, old_color, old_wight));
            }

            mode = "line";
            panel1.Invalidate();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown) 
            {
                points[0][1].X = e.X;
                points[0][1].Y = e.Y;
 
            }
            else
            {
                point_focused = false;
                catch_line_index = -1;
                catch_point_index = -1;
                mode = "line";

                for (int i = 0; i < arrayLines.Count(); i++)
                {
                    if (Math.Abs(arrayLines[i].getX1() - e.X) < 5 && Math.Abs(arrayLines[i].getY1() - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_line_index = i;
                        catch_point_index = 1;
                        mode = "change";
                    }
                    if (Math.Abs(arrayLines[i].getX2() - e.X) < 5 && Math.Abs(arrayLines[i].getY2() - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_line_index = i;
                        catch_point_index = 2;
                        mode = "change";
                    }
                }
            }
            panel1.Invalidate();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            if (point_focused && !mouseDown)
            {
                float new_x = -1, new_y = -1;
                if(catch_point_index == 1)
                {
                    new_x = arrayLines[catch_line_index].getX1();
                    new_y = arrayLines[catch_line_index].getY1();
                }
                if (catch_point_index == 2)
                {
                    new_x = arrayLines[catch_line_index].getX2();
                    new_y = arrayLines[catch_line_index].getY2();
                }
                graphics.DrawRectangle(new Pen(Color.Red), new_x - 5, new_y - 5, 10, 10);
            }
            if (mouseDown)
            {
                
                if(mode == "change")
                {
                    graphics.DrawLine(new Pen(old_color, old_wight), points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y);
                }
                else
                {
                    graphics.DrawLine(new Pen(color, wight), points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y);

                }
                
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
            color = ((Button)sender).BackColor;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            arrayLines.Clear();
            panel1.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //save
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)new Bitmap(500,500);
            Graphics g = Graphics.FromImage(pictureBox.Image);

            foreach (Line line in arrayLines)
            {
                g.DrawLine(new Pen(line.getColor(), line.getWigth()), line.getX1(), line.getY1(), line.getX2(), line.getY2());
            }
            pictureBox.Invalidate();
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(pictureBox.Image != null)
                {
                    pictureBox.Image.Save(saveFileDialog1.FileName);    
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;

            }
        }


        private void SizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            wight = SizeList.SelectedIndex;
        }
    }
}
