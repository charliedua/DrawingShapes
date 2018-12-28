using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    internal class Square : Shape
    {
        public Square(int x, int y, int width, Color color) : base(x, y, color)
        {
            Width = width;
        }

        public Square(int x, int y) : this(x, y, 50, Color.Black)
        {
        }

        public int Width { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color), X, Y, Width, Width);
            base.Draw(graphics);
        }

        public override void DrawOutline(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color), X - 2, Y - 2, Width + 4, Width + 4);
        }

        public override bool Contains(Point location)
        {
            return new RectangleF(X, Y, Width, Width).Contains(location);
        }
    }
}