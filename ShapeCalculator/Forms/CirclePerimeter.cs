using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeCalculator.Classes;

namespace ShapeCalculator
{
    public partial class CirclePerimeter : Form
    {
        public CirclePerimeter()
        {
            InitializeComponent();
        }

        private void CirclePerimeter_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!tbRadius.Text.Equals(""))
            {
                Regex r = new Regex("[^0-9.]");

                if (!r.IsMatch(tbRadius.Text))
                {
                    if (double.TryParse(tbRadius.Text, out double radius))
                    {
                        // Calculate circumference (perimeter) and fill tbCircum
                        tbCircum.Text = Circle.GetPerimeter(radius).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error: Cannot parse input", "Parsing Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Input must be strictly numeric and positive", "Invalid Input Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
