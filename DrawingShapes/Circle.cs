using System.Drawing;

namespace DrawingShapes
{
    public class Circle : Shape
    {
        public Circle(int X, int Y, int radius, Color color) : base(X, Y, color)
        {
            Radius = radius;
        }

        public Circle(int X, int Y) : this(X, Y, 50, Color.Pink)
        { }

        public int Radius { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color), X, Y, Radius, Radius);
            base.Draw(graphics);
        }

        public override void DrawOutline(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color), X - 2, Y - 2, Radius + 4, Radius + 4);
        }

        public override bool Contains(Point location)
        {
            return new RectangleF(X, Y, Radius, Radius).Contains(location);
        }
    }
}