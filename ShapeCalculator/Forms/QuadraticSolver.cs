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

namespace ShapeCalculator.Forms
{
    public partial class QuadraticSolver : Form
    {
        public QuadraticSolver()
        {
            InitializeComponent();
        }

        private void Quadratic_Load(object sender, EventArgs e)
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
            if (!tbXSquared.Text.Equals("") && !tbX.Text.Equals("") && !tbC.Text.Equals(""))
            {
                Regex r = new Regex("[^0-9.-]");

                if (!r.IsMatch(tbXSquared.Text) && !r.IsMatch(tbX.Text) && !r.IsMatch(tbC.Text))
                {
                    if (double.TryParse(tbXSquared.Text, out double x2))
                    {
                        if (double.TryParse(tbX.Text, out double x))
                        {
                            if (double.TryParse(tbC.Text, out double c))
                            {
                                var solutions = Quadratic.Solve(x2, x, c);

                                lbSolutions.Text = solutions.Item1 + ":";
                                tbSolutions.Text = solutions.Item2;
                            }
                            else
                            {
                                MessageBox.Show("Error: Cannot parse 'x^2' input", "Parsing Error", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Cannot parse 'x' input", "Parsing Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Cannot parse '+c' input", "Parsing Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Input must be strictly numeric", "Invalid Input Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
