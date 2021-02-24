using ShapeCalculator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCalculator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbOperation.Text.Equals("Quadratic Solver"))
            {
                this.Hide();
                QuadraticSolver qs = new QuadraticSolver();
                qs.ShowDialog();
                this.Close();
            }
            else if (!cbOperation.Text.Equals("") && !cbShape.Text.Equals(""))
            {
                if (cbOperation.Text.Equals("Calculate Area"))
                {
                    if (cbShape.Text.Equals("Circle"))
                    {
                        this.Hide();
                        CircleArea circleArea = new CircleArea();
                        circleArea.ShowDialog();
                        this.Close();
                    }
                    else if (cbShape.Text.Equals("Square"))
                    {
                        this.Hide();
                        SquareArea squareArea = new SquareArea();
                        squareArea.ShowDialog();
                        this.Close();
                    }
                    else if (cbShape.Text.Equals("Triangle"))
                    {
                        this.Hide();
                        TriangleArea triangleArea = new TriangleArea();
                        triangleArea.ShowDialog();
                        this.Close();
                    }
                }
                else if (cbOperation.Text.Equals("Calculate Perimeter"))
                {
                    if (cbShape.Text.Equals("Circle"))
                    {
                        this.Hide();
                        CirclePerimeter circlePerimeter = new CirclePerimeter();
                        circlePerimeter.ShowDialog();
                        this.Close();
                    }
                    else if (cbShape.Text.Equals("Square"))
                    {
                        this.Hide();
                        SquarePerimeter squarePerimeter = new SquarePerimeter();
                        squarePerimeter.ShowDialog();
                        this.Close();
                    }
                    else if (cbShape.Text.Equals("Triangle"))
                    {
                        this.Hide();
                        TrianglePerimeter trianglePerimeter = new TrianglePerimeter();
                        trianglePerimeter.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
