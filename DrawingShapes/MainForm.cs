using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes
{
    public partial class MainForm : Form
    {
        private Type shapeType = typeof(Circle);
        private List<Shape> shapes;

        public MainForm()
        {
            InitializeComponent();
            shapes = new List<Shape>
            {
                new Rectangle(0, 0, 10, 20, Color.Green),
                new Circle(100, 100, 50, Color.Black),
                new Square(0, 40, 40, Color.Pink)
            };
        }

        public void DrawAllShapes(Graphics graphics)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics);
            }
        }

        private void DrawingPannel_Paint(object sender, PaintEventArgs e)
        {
            DrawAllShapes(DrawingPannel.CreateGraphics());
        }

        private void DrawingPannel_Click(object sender, EventArgs e)
        {
            shapes.Add((Shape)Activator.CreateInstance(
                shapeType, (e as MouseEventArgs).X, (e as MouseEventArgs).Y));
            Graphics graphics = DrawingPannel.CreateGraphics();
            DrawAllShapes(graphics);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'R':
                case 'r':
                    shapeType = typeof(Rectangle);
                    break;

                case 'S':
                case 's':
                    shapeType = typeof(Square);
                    break;

                case 'C':
                case 'c':
                    shapeType = typeof(Circle);
                    break;

                case ' ':
                    Graphics graphics = DrawingPannel.CreateGraphics();
                    Random random = new Random();
                    graphics.Clear(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                    DrawAllShapes(graphics);
                    break;

                default:
                    break;
            }
        }
    }
}