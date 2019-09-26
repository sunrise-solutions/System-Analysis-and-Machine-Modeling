using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distributions
{
    public partial class MainForm : Form
    {
        private void Button2_Click(object sender, EventArgs e)
        {
            int Rm = 0, Ra = 0, RR0 = 0, gaus_n = 0;
            double m = 0, sigma = 0;
            if (!int.TryParse(gausRmtextBox.Text, out Rm) || !int.TryParse(gausRatextBox.Text, out Ra) ||
                !int.TryParse(gausRR0textBox.Text, out RR0) || !double.TryParse(gausMtextBox.Text, out m) ||
                !double.TryParse(gausSigmatextBox.Text, out sigma) || !int.TryParse(gausNtextBox.Text, out gaus_n))
            {
                MessageBox.Show("Значения не верны");
                return;
            }

            Generator generator = new Generator(Ra, Rm, RR0);
            List<double> sequence = new List<double>();
            sequence = Distribution.Gauss(generator.GetNext().Take(N), m, sigma, gaus_n);

            CalculateGaussDistributionEstimates(sequence);
        }

        private void CalculateGaussDistributionEstimates(List<double> sequence)
        {
            double Mx, Dx, γx;
            CalculateDistributionEstimates(sequence, out Mx, out Dx, out γx);

            gausMReslabel.Text = "M = " + Math.Round(Mx, 5).ToString();
            gausDReslabel.Text = "D = " + Math.Round(Dx, 4).ToString();
            gausSigmaReslabel.Text = "σ = " + Math.Round(γx, 4).ToString();
        }
    }
}