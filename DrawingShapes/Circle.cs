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
        }
    }
}