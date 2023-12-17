using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
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
        private List<List<Line>> arrayLayer;  
        private List<List<Figure>> arrayLayerFigure;
        Point[][] points;
        Color color, old_color;
        float wight, old_wight;
        int catch_line_index;
        int catch_figure_index;
        bool point_focused;
        int catch_point_index;
        int catchLayerIndex;
        //Bitmap map = new Bitmap(256, 256);
        Graphics graphics;
        string mode;
        string modeFigure;
        int catch_figure;

        public Form1()
        {
            InitializeComponent();

            arrayLines = new List<Line>();
            arrayLayer = new List<List<Line>>();
            arrayLayerFigure = new List<List<Figure>>();    
            arrayLayer.Add(arrayLines);
            arrayLayerFigure.Add(new List<Figure>());
            catchLayerIndex = 0;
            points = new Point[1][];
            points[0] = new Point[2];
            string[] listSize = {"1", "2", 
                "3", "4", "5", "6", "7", "8", "9", "10"};
            SizeList.Items.AddRange(listSize);
            LayerList.Items.Add("слой №1");
            LayerList.SetSelected(0, true);
            color = Color.Black;
            wight = 1;
            old_color = Color.Black;
            old_wight = 1;
            point_focused = false;
            catch_figure = -1;
            catch_line_index = -1;
            catch_point_index = -1;
            catch_figure_index = -1;
            mode = "line";
            modeFigure = "line";
        }
     

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            /*
            if (mode == "rectangle")
            {
                points[0][0].X = e.X;
                points[0][0].Y = e.Y;
            }
            */
            if (mode == "line" || mode == "rectangle" || mode == "circle")
            {
                points[0][0].X = e.X;
                points[0][0].Y = e.Y;
            }
            if (mode == "change")
            {
                if (modeFigure == "line")
                {
                    old_color = arrayLayer[catchLayerIndex][catch_line_index].getColor();
                    old_wight = arrayLayer[catchLayerIndex][catch_line_index].getWigth();

                    if (catch_point_index == 1)
                    {
                        points[0][0].X = (int)arrayLayer[catchLayerIndex][catch_line_index].getX2();
                        points[0][0].Y = (int)arrayLayer[catchLayerIndex][catch_line_index].getY2();
                        points[0][1].X = e.X;
                        points[0][1].Y = e.Y;
                    }
                    if (catch_point_index == 2)
                    {
                        points[0][0].X = (int)arrayLayer[catchLayerIndex][catch_line_index].getX1();
                        points[0][0].Y = (int)arrayLayer[catchLayerIndex][catch_line_index].getY1();
                        points[0][1].X = e.X;
                        points[0][1].Y = e.Y;
                    }
                    arrayLayer[catchLayerIndex].Remove(arrayLayer[catchLayerIndex][catch_line_index]);
                }
                else
                {
                    old_color = arrayLayerFigure[catchLayerIndex][catch_figure_index].getColor();
                    old_wight = arrayLayerFigure[catchLayerIndex][catch_figure_index].getWight();

                    if (catch_figure == 1)
                    {
                        points[0][0].X = arrayLayerFigure[catchLayerIndex][catch_figure_index].getEndPoint().X;
                        points[0][0].Y = arrayLayerFigure[catchLayerIndex][catch_figure_index].getEndPoint().Y;
                        points[0][1].X = e.X;
                        points[0][1].Y = e.Y;
                    }
                    if (catch_figure == 2)
                    {
                        points[0][0].X = arrayLayerFigure[catchLayerIndex][catch_figure_index].getStartPoint().X;
                        points[0][0].Y = arrayLayerFigure[catchLayerIndex][catch_figure_index].getStartPoint().Y;
                        points[0][1].X = e.X;
                        points[0][1].Y = e.Y;
                    }
                    arrayLayerFigure[catchLayerIndex].Remove(arrayLayerFigure[catchLayerIndex][catch_figure_index]);
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            points[0][1].X = e.X;
            points[0][1].Y = e.Y;
            if (mode == "line")
            {
                arrayLayer[catchLayerIndex].Add(new Line(points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y, color, wight));
            }

            if (mode == "change")
            {
                if (modeFigure == "line")
                {
                    arrayLayer[catchLayerIndex].Add(new Line(points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y, old_color, old_wight));
                }
                if (modeFigure == "rectangle")
                {
                    Rectangle tmp = new Rectangle();
                    tmp.setStartPoint(points[0][0]);
                    tmp.setEndPoint(points[0][1]);
                    tmp.setColor(old_color);
                    tmp.setWight(old_wight);
                    arrayLayerFigure[catchLayerIndex].Add(tmp);
                }
                if(modeFigure == "circle")
                {
                    Circle tmp = new Circle();
                    tmp.setStartPoint(points[0][0]);
                    tmp.setEndPoint(points[0][1]);
                    tmp.setColor(old_color);
                    tmp.setWight(old_wight);
                    arrayLayerFigure[catchLayerIndex].Add(tmp);
                }
            }
            
            if (mode == "rectangle")
            {
                Rectangle tmp = new Rectangle();
                tmp.setStartPoint(points[0][0]);
                tmp.setEndPoint(points[0][1]);
                tmp.setColor(color);
                tmp.setWight(wight);
                arrayLayerFigure[catchLayerIndex].Add(tmp);
            }
            if (mode == "circle")
            {
                Circle tmp = new Circle();
                tmp.setStartPoint(points[0][0]);
                tmp.setEndPoint(points[0][1]);
                tmp.setColor(color);
                tmp.setWight(wight);
                arrayLayerFigure[catchLayerIndex].Add(tmp);
            }

            mode = modeFigure;


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
            else
            {
              
                point_focused = false;
                catch_line_index = -1;
                catch_point_index = -1;
                catch_figure = -1;
                catch_figure_index = -1;
                mode = modeFigure;

                for (int i = 0; i < arrayLayer[catchLayerIndex].Count(); i++)
                {
                    if (Math.Abs(arrayLayer[catchLayerIndex][i].getX1() - e.X) < 5 && Math.Abs(arrayLayer[catchLayerIndex][i].getY1() - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_line_index = i;
                        catch_point_index = 1;
                        mode = "change";
                        modeFigure = "line";
                    }
                    if (Math.Abs(arrayLayer[catchLayerIndex][i].getX2() - e.X) < 5 && Math.Abs(arrayLayer[catchLayerIndex][i].getY2() - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_line_index = i;
                        catch_point_index = 2;
                        mode = "change";
                        modeFigure = "line";
                    }
                }
                for (int i = 0; i < arrayLayerFigure[catchLayerIndex].Count(); i++)
                {
                    if (Math.Abs(arrayLayerFigure[catchLayerIndex][i].getStartPoint().X - e.X) < 5 && Math.Abs(arrayLayerFigure[catchLayerIndex][i].getStartPoint().Y - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_figure_index = i;
                        catch_figure = 1;
                        mode = "change";
                        modeFigure = arrayLayerFigure[catchLayerIndex][i].TypeFigure();
                    }
                    if (Math.Abs(arrayLayerFigure[catchLayerIndex][i].getEndPoint().X - e.X) < 5 && Math.Abs(arrayLayerFigure[catchLayerIndex][i].getEndPoint().Y - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_figure_index = i;
                        catch_figure = 2;
                        mode = "change";
                        modeFigure = arrayLayerFigure[catchLayerIndex][i].TypeFigure();
                    }
                }


            }
            if (point_focused) panel1.Invalidate();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            if (point_focused && !mouseDown)
            {
                float new_x = -1, new_y = -1;
                if(catch_point_index == 1)
                {
                    new_x = arrayLayer[catchLayerIndex][catch_line_index].getX1();
                    new_y = arrayLayer[catchLayerIndex][catch_line_index].getY1();
                }
                if (catch_point_index == 2)
                {
                    new_x = arrayLayer[catchLayerIndex][catch_line_index].getX2();
                    new_y = arrayLayer[catchLayerIndex][catch_line_index].getY2();
                }
                if (catch_figure == 1)
                {
                    new_x = arrayLayerFigure[catchLayerIndex][catch_figure_index].getStartPoint().X;
                    new_y = arrayLayerFigure[catchLayerIndex][catch_figure_index].getStartPoint().Y;
                }
                if (catch_figure == 2)
                {
                    new_x = arrayLayerFigure[catchLayerIndex][catch_figure_index].getEndPoint().X;
                    new_y = arrayLayerFigure[catchLayerIndex][catch_figure_index].getEndPoint().Y;
                }
                graphics.DrawRectangle(new Pen(Color.Red), new_x - 5, new_y - 5, 10, 10);
            }
            if (mouseDown)
            {
                if (mode == "rectangle")
                {
                    int x = Math.Min(points[0][0].X, points[0][1].X);
                    int y = Math.Min(points[0][0].Y, points[0][1].Y);
                    int wightR = Math.Abs(points[0][1].X - points[0][0].X);
                    int hightR = Math.Abs(points[0][1].Y - points[0][0].Y);
                    graphics.DrawRectangle(new Pen(color, wight), x,y, wightR, hightR);

                }
                
                if (mode == "circle")
                {
                    int x = Math.Min(points[0][0].X, points[0][1].X);
                    int y = Math.Min(points[0][0].Y, points[0][1].Y);
                    int wightR = Math.Abs(points[0][1].X - points[0][0].X);
                    int hightR = Math.Abs(points[0][1].Y - points[0][0].Y);
                    RectangleF tmp = new RectangleF(x, y, wightR, hightR);
                    graphics.DrawEllipse(new Pen(color, wight), tmp);
                }

                if (mode == "change")
                {
                    if (modeFigure == "line")
                    {
                        graphics.DrawLine(new Pen(old_color, old_wight), points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y);
                    }
                    
                    if (modeFigure =="rectangle")
                    {
                        int x = Math.Min(points[0][0].X, points[0][1].X);
                        int y = Math.Min(points[0][0].Y, points[0][1].Y);
                        int wightR = Math.Abs(points[0][1].X - points[0][0].X);
                        int hightR = Math.Abs(points[0][1].Y - points[0][0].Y);
                        graphics.DrawRectangle(new Pen(old_color, old_wight), x, y, wightR, hightR);
                    }
                    if (modeFigure == "circle")
                    {
                        int x = Math.Min(points[0][0].X, points[0][1].X);
                        int y = Math.Min(points[0][0].Y, points[0][1].Y);
                        int wightR = Math.Abs(points[0][1].X - points[0][0].X);
                        int hightR = Math.Abs(points[0][1].Y - points[0][0].Y);
                        RectangleF tmp = new RectangleF(x, y, wightR, hightR);
                        graphics.DrawEllipse(new Pen(color, wight), tmp);
                    }

                }
                if (mode == "line")
                {
                    graphics.DrawLine(new Pen(color, wight), points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y);

                }
                
            }

            foreach(List<Line> layer in arrayLayer)
            {
               foreach(Line line in layer)
                {
                    graphics.DrawLine(new Pen(line.getColor(), line.getWigth()), line.getX1(), line.getY1(), line.getX2(), line.getY2());
                }
            }
 
            foreach (List<Figure> layer in arrayLayerFigure)
            {
                foreach (Figure figure in layer)
                {
                    figure.Draw(graphics);
                }
            }
        }

        private void color1_Click(object sender, EventArgs e)
        {
            color = ((Button)sender).BackColor;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            foreach (List<Line> layer in arrayLayer)
            {
                layer.Clear();
            }
            foreach(List<Figure> layer in arrayLayerFigure)
            { layer.Clear(); }

            arrayLines.Clear();
            arrayLayer.Clear();
            arrayLayerFigure.Clear();
            arrayLayer.Add(arrayLines);
            arrayLayerFigure.Add(new List<Figure>());
            LayerList.Items.Clear();
            LayerList.Items.Add("слой №1");
            LayerList.SetSelected(0, true);
            catchLayerIndex = 0;
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

            pictureBox.Image = (Image)new Bitmap(panel1.Width,panel1.Height);
            Graphics g = Graphics.FromImage(pictureBox.Image);
            g.Clear(panel1.BackColor);
            

            foreach (List<Line> layer in arrayLayer)
            {
                foreach (Line line in layer)
                {
                    Pen linePen = new Pen(line.getColor(), line.getWigth());
                    g.DrawLine(linePen, line.getX1(), line.getY1(), line.getX2(), line.getY2());
                }
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

        private void button12_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog2.Color;
                ((Button)sender).BackColor = colorDialog2.Color;

            }
        }

        private void LayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            catchLayerIndex = LayerList.SelectedIndex;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LayerList.Items.Add($"слой №{arrayLayer.Count()+1}");
          //  arrayLines.Clear();
            arrayLayer.Add(new List<Line>());
            arrayLayerFigure.Add(new List<Figure>());
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (arrayLayer.Count > 1)
            {
                LayerList.Items.Clear();
                arrayLayer.Remove(arrayLayer[catchLayerIndex]);
                arrayLayerFigure.Remove(arrayLayerFigure[catchLayerIndex]);
                for (int i = 0; i < arrayLayer.Count(); i++)
                {
                    LayerList.Items.Add($"слой №{i + 1}");
                }
                LayerList.SetSelected(0, true);
            }
            else
            {
                arrayLayer[0].Clear();
            }
            panel1.Invalidate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            mode = "rectangle";
            modeFigure = "rectangle";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mode = "line";
            modeFigure = "line";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mode = "circle";
            modeFigure = "circle";
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
