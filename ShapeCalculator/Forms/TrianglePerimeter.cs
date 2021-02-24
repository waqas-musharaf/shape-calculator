using ShapeCalculator.Classes;
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

namespace ShapeCalculator.Forms
{
    public partial class TrianglePerimeter : Form
    {
        public TrianglePerimeter()
        {
            InitializeComponent();
        }

        private void TrianglePerimeter_Load(object sender, EventArgs e)
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
            if (!tbLenA.Text.Equals("") && !tbLenB.Text.Equals("") && !tbLenC.Text.Equals(""))
            {
                Regex r = new Regex("[^0-9.]");

                if (!r.IsMatch(tbLenA.Text) && !r.IsMatch(tbLenB.Text) && !r.IsMatch(tbLenC.Text))
                {
                    if (double.TryParse(tbLenA.Text, out double a))
                    {
                        if (double.TryParse(tbLenB.Text, out double b))
                        {
                            if (double.TryParse(tbLenC.Text, out double c))
                            {
                                tbPerim.Text = Triangle.GetPerimeter(a, b, c).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Error: Cannot parse 'Length C' input", "Parsing Error", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Cannot parse 'Length B' input", "Parsing Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Cannot parse 'Length A' input", "Parsing Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Error: All inputs must be strictly numeric and positive", "Invalid Input Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
