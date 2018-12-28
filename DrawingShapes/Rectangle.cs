using System.Drawing;

namespace DrawingShapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height, Color color) : base(x, y, color)
        {
            Height = height;
            Width = width;
        }

        public Rectangle(int x, int y) : this(x, y, 50, 100, Color.Green)
        { }

        public int Height { get; set; }
        public int Width { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
            base.Draw(graphics);
        }

        public override void DrawOutline(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color), X - 2, Y - 2, Width + 4, Height + 4);
        }

        public override bool Contains(Point location)
        {
            return new RectangleF(X, Y, Width, Height).Contains(location);
        }
    }
}