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
        private void Button4_Click(object sender, EventArgs e)
        {
            int Rm = 0, Ra = 0, RR0 = 0, n = 0;
            double l = 0;
            if (!int.TryParse(gammaRmtextBox.Text, out Rm) || !int.TryParse(gammaRatextBox.Text, out Ra) ||
                !int.TryParse(gammaRR0textBox.Text, out RR0) || !double.TryParse(gammaLtextBox.Text, out l) ||
                !int.TryParse(gammaNtextBox.Text, out n))
            {
                MessageBox.Show("Значения не верны");
                return;
            }

            Generator generator = new Generator(Ra, Rm, RR0);
            List<double> sequence = new List<double>();
            sequence = Distribution.Gamma(generator.GetNext().Take(N), l, n);

            CalculateGammaDistributionEstimates(l, n);
        }

        private void CalculateGammaDistributionEstimates(double l, int n)
        {
            double Mx, Dx, γx;
            Mx = n / l;
            Dx = n / (Math.Pow(l, 2));
            γx = Math.Sqrt(Dx);

            gammaMReslabel.Text = "M = " + Math.Round(Mx, 5).ToString();
            gammaDReslabel.Text = "D = " + Math.Round(Dx, 4).ToString();
            gammaSigmaReslabel.Text = "σ = " + Math.Round(γx, 4).ToString();
        }
    }
}