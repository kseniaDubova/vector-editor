using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace VEditor
{
    public partial class Form1 : Form
    {
        private bool mouseDown = false;
 
        private List<List<Figure>> arrayLayerFigure;
        Point[][] points;
        Color color, old_color;
        float wight, old_wight;

        int catch_figure_index;
        bool point_focused;

        int catchLayerIndex;

        Graphics graphics;
        string mode;
        string modeFigure;
        int catch_figure;

        public Form1()
        {
            InitializeComponent();


            arrayLayerFigure = new List<List<Figure>>();    

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

            catch_figure_index = -1;
            mode = "linel";
            modeFigure = "linel";
        }
     

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
       
            if (mode != "change")
            {
                points[0][0].X = e.X;
                points[0][0].Y = e.Y;
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            points[0][1].X = e.X;
            points[0][1].Y = e.Y;

            if (mode == "change")
            {
                if (modeFigure == "linel")
                {
                    Line tmp = new Line();
                    tmp.setStartPoint(points[0][0]);
                    tmp.setEndPoint(points[0][1]);
                    tmp.setColor(old_color);
                    tmp.setWight(old_wight);
                    arrayLayerFigure[catchLayerIndex].Add(tmp);
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
            else
            {
                if (mode == "linel")
                {
                    Line tmp = new Line();
                    tmp.setStartPoint(points[0][0]);
                    tmp.setEndPoint(points[0][1]);
                    tmp.setColor(color);
                    tmp.setWight(wight);
                    arrayLayerFigure[catchLayerIndex].Add(tmp);
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
                catch_figure = -1;
                catch_figure_index = -1;
                mode = modeFigure;

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

                if (mode == "change")
                {
                    if (modeFigure == "linel")
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
                else
                {
                    if (mode == "linel")
                    {
                        graphics.DrawLine(new Pen(color, wight), points[0][0].X, points[0][0].Y, points[0][1].X, points[0][1].Y);

                    }
                    if (mode == "rectangle")
                    {
                        int x = Math.Min(points[0][0].X, points[0][1].X);
                        int y = Math.Min(points[0][0].Y, points[0][1].Y);
                        int wightR = Math.Abs(points[0][1].X - points[0][0].X);
                        int hightR = Math.Abs(points[0][1].Y - points[0][0].Y);
                        graphics.DrawRectangle(new Pen(color, wight), x, y, wightR, hightR);

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


        private void delete_Click(object sender, EventArgs e)
        {

            foreach(List<Figure> layer in arrayLayerFigure)
            { layer.Clear(); }

            arrayLayerFigure.Clear();
 
            arrayLayerFigure.Add(new List<Figure>());
            LayerList.Items.Clear();
            LayerList.Items.Add("слой №1");
            LayerList.SetSelected(0, true);
            catchLayerIndex = 0;
            panel1.Invalidate();
        }


        private void createTxt(string path)
        {
            using (FileStream file = File.Open(path, FileMode.Create))
            {
                using (StreamWriter output = new StreamWriter(file))
                {
                    output.Write($"Цвет фона: {panel1.BackColor}\n\n");
                    for (int i = 0; i < arrayLayerFigure.Count(); i++)
                    {
                        output.Write($"слой №{i + 1}\n");
                        foreach (Figure figure in arrayLayerFigure[i])
                        {
                            output.Write($"\tТип фигуры: {figure.TypeFigure()}\n");
                            output.Write($"\t\tТочка начала:{figure.getStartPoint()}\n");
                            output.Write($"\t\tТочка конца:{figure.getEndPoint()}\n");
                            output.Write($"\t\tЦвет фигуры:{figure.getColor()}\n");
                            output.Write($"\t\tШирина линии: {figure.getWight()}\n");
                        }
                    }
                }
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            //save
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = (Image)new Bitmap(panel1.Width,panel1.Height);
            Graphics g = Graphics.FromImage(pictureBox.Image);
            g.Clear(panel1.BackColor);
            

            foreach (List<Figure> layer in arrayLayerFigure)
            {
                foreach (Figure figure in layer)
                {
                    Pen linePen = new Pen(figure.getColor(), figure.getWight());
                    figure.Draw(g);
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
            string path = saveFileDialog1.FileName.Replace("jpg", "txt");
            createTxt(path);

        }

        private void backcolor_Click(object sender, EventArgs e)
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

        private void LayerAdd_Click(object sender, EventArgs e)
        {
            LayerList.Items.Add($"слой №{arrayLayerFigure.Count()+1}");
            arrayLayerFigure.Add(new List<Figure>());
           
        }

        private void LayerDelete_Click(object sender, EventArgs e)
        {
            if (arrayLayerFigure.Count > 1)
            {
                LayerList.Items.Clear();
                arrayLayerFigure.Remove(arrayLayerFigure[catchLayerIndex]);
                for (int i = 0; i < arrayLayerFigure.Count(); i++)
                {
                    LayerList.Items.Add($"слой №{i + 1}");
                }
                LayerList.SetSelected(0, true);
            }
            else
            {
                arrayLayerFigure[0].Clear();
            }
            panel1.Invalidate();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            mode = "rectangle";
            modeFigure = "rectangle";
        }

        private void line_Click(object sender, EventArgs e)
        {
            mode = "linel";
            modeFigure = "linel";
        }

        private void circle_Click(object sender, EventArgs e)
        {
            mode = "circle";
            modeFigure = "circle";
        }

        private void color2_Click(object sender, EventArgs e)
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
