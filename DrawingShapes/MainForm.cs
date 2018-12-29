using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingShapes
{
    public partial class MainForm : Form
    {
        private Type shapeType = typeof(Circle);
        private List<Shape> shapes;
        private Graphics DrawingArea;
        private Color CurrentBackgroundColor = Color.FromArgb(240, 240, 240);

        public MainForm()
        {
            InitializeComponent();
            DrawingArea = DrawingPannel.CreateGraphics();
            shapes = new List<Shape>();
        }

        public void DrawAllShapes(Graphics graphics)
        {
            DrawingArea.Clear(CurrentBackgroundColor);
            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics);
            }
        }

        private void DrawingPannel_Paint(object sender, PaintEventArgs e)
        {
            DrawAllShapes(DrawingArea);
        }

        private void DrawingPannel_Click(object sender, EventArgs e)
        {
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
                    Graphics graphics = DrawingArea;
                    Random random = new Random();
                    graphics.Clear(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                    break;

                default:
                    if (true)
                    {
                    }
                    break;
            }
        }

        private void DrawingPannel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Contains(e.Location))
                    {
                        shape.Selected = !shape.Selected;
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                shapes.Add((Shape)Activator.CreateInstance(
                shapeType, (e as MouseEventArgs).X, (e as MouseEventArgs).Y));
            }
            DrawAllShapes(DrawingArea);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                var newshapes = new List<Shape>();
                foreach (var shape in shapes)
                {
                    if (shape.Selected)
                    {
                        newshapes.Add(shape);
                    }
                }
                shapes = newshapes;
            }
            else if (e.KeyData == Keys.Left)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Selected)
                    {
                        shape.X -= 1;
                    }
                }
            }
            else if (e.KeyData == Keys.Right)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Selected)
                    {
                        shape.X += 1;
                    }
                }
            }
            else if (e.KeyData == Keys.Up)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Selected)
                    {
                        shape.Y -= 1;
                    }
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                foreach (var shape in shapes)
                {
                    if (shape.Selected)
                    {
                        shape.Y += 1;
                    }
                }
            }
            DrawAllShapes(DrawingArea);
        }
    }
}