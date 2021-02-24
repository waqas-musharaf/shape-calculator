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
    public partial class TriangleArea : Form
    {
        public TriangleArea()
        {
            InitializeComponent();
        }

        private void TriangleArea_Load(object sender, EventArgs e)
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
                                string area = Triangle.GetArea(a, b, c).ToString();

                                if (area.Equals("0") || area.ToLowerInvariant().Equals("nan"))
                                {
                                    MessageBox.Show("Error: Given sides result in impossible triangle", "Impossible Triangle Error", MessageBoxButtons.OK);
                                    tbLenA.Text = "";
                                    tbLenB.Text = "";
                                    tbLenC.Text = "";
                                    tbArea.Text = "";
                                }
                                else
                                {
                                    tbArea.Text = area;
                                }
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

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbLenA_Click(object sender, EventArgs e)
        {

        }

        private void tbLenA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbLenB_Click(object sender, EventArgs e)
        {

        }

        private void tbLenB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbLenC_Click(object sender, EventArgs e)
        {

        }

        private void tbLenC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbArea_Click(object sender, EventArgs e)
        {

        }

        private void tbArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
