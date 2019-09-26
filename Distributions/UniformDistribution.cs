using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distributions
{
    public partial class MainForm : Form
    {
        private void Button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(unMTextBox.Text);
            int coefficientA = Convert.ToInt32(unCoefficientATextBox.Text);
            int R0 = Convert.ToInt32(unR0TextBox.Text);

            Generator generator = new Generator(coefficientA, m, R0);
            List<double> sequence = new List<double>();

            double a = double.Parse(unATextBox.Text);
            double b = double.Parse(unBTextBox.Text);
            sequence = Distribution.Uniform(generator.GetNext().Take(N), a, b);

            CalculateUniformDistributionEstimates(a, b);
        }

        private void CalculateUniformDistributionEstimates(double a, double b)
        {
            double Mx = (a + b) / 2;
            double Dx = Math.Pow(b - a, 2) / 12;
            double γx = Math.Sqrt(Dx);

            unMxValueLabel.Text = Math.Round(Mx, 5).ToString();
            unDxValueLabel.Text = Math.Round(Dx, 4).ToString();
            unγxValueLabel.Text = Math.Round(γx, 4).ToString();
        }
    }
}
