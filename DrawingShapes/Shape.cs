using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public bool Selected { get; set; }

        protected Shape(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw(Graphics graphics)
        {
            if (Selected)
            {
                DrawOutline(graphics);
            }
        }

        public abstract void DrawOutline(Graphics graphics);

        public abstract bool Contains(Point location);
    }
}