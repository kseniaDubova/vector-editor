using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEditor
{
    public struct Line
    {
        private float _x1, _y1;
        private float _x2, _y2;
       // Pen _pen;
        Color _color;
        float _wight;
      
        public Line(float x1, float y1, float x2, float y2, Color color, float wight)
        {   
            _x1 = x1; 
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
            _color = color;
            _wight = wight;
        }
        public float getX1() { return _x1;}
        public float getY1() { return _y1;}
        public float getX2() { return _x2;}    
        public float getY2() { return _y2;}
        public Color getColor() { return _color;}
        public float getWigth() { return _wight;}


    }

}
