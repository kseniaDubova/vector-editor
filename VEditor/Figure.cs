﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEditor
{
    public abstract class Figure
    {/*
        public Figure(Point p1, Point p2, Color color, float wight) 
        {
            Startpoint = p1;
            Endpoint = p2;
            _color = color;
            _wight = wight;
        }
        */
        public Point Startpoint;
        public Point Endpoint;
        public Color _color;
        public float _wight;

        public void setStartPoint(Point point) { Startpoint = point; }
        public void setEndPoint(Point point) { Endpoint = point; }
        public void setColor(Color color) { _color = color; }
        public void setWight(float wight) { _wight = wight; }

        public Point getStartPoint() { return Startpoint; }
        public Point getEndPoint() { return Endpoint; }
        public Color getColor() { return _color; }
        public float getWight() { return _wight; }
        public virtual void Draw(Graphics g) { }
        public virtual string TypeFigure() { return "line"; }
    }

    public class Rectangle: Figure
    {
        
        public override void Draw(Graphics g)
        {
            int x = Math.Min(Startpoint.X, Endpoint.X);
            int y = Math.Min(Startpoint.Y, Endpoint.Y);
            int wight = Math.Abs(Endpoint.X - Startpoint.X);
            int hight = Math.Abs(Endpoint.Y - Startpoint.Y);
            g.DrawRectangle(new Pen(_color, _wight), x, y, wight, hight);   
        }
        public override string TypeFigure() { return "rectangle"; }
    }

    public class Circle: Figure
    {
        public override void Draw(Graphics g)
        {
            int x = Math.Min(Startpoint.X, Endpoint.X);
            int y = Math.Min(Startpoint.Y, Endpoint.Y);
            int wight = Math.Abs(Endpoint.X - Startpoint.X);
            int hight = Math.Abs(Endpoint.Y - Startpoint.Y);
            RectangleF tmp = new RectangleF(x, y, wight, hight);
            g.DrawEllipse(new Pen(_color, _wight), tmp);
        }
        public override string TypeFigure() { return "circle"; }
    }
}