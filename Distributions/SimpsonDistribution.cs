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
        private void Button6_Click(object sender, EventArgs e)
        {
            int Rm = 0, Ra = 0, RR0 = 0;
            double a = 0, b = 0;
            if (!int.TryParse(simpRmtextBox.Text, out Rm) || !int.TryParse(simpRatextBox.Text, out Ra) ||
                !int.TryParse(simpRR0textBox.Text, out RR0) || !double.TryParse(simpAtextBox.Text, out a) ||
                !double.TryParse(simpBtextBox.Text, out b))
            {
                MessageBox.Show("Значения не верны");
                return;
            }

            Generator generator = new Generator(Ra, Rm, RR0);
            List<double> sequence = new List<double>();
            sequence = Distribution.Simpson(generator.GetNext().Take(N), a, b);

            CalculateSimpsonDistributionEstimates(sequence);
        }

        private void CalculateSimpsonDistributionEstimates(List<double> sequence)
        {
            double Mx, Dx, γx;
            CalculateDistributionEstimates(sequence, out Mx, out Dx, out γx);

            simpMReslabel.Text = "M = " + Math.Round(Mx, 5).ToString();
            simpDReslabel.Text = "D = " + Math.Round(Dx, 4).ToString();
            simpSigmaReslabel.Text = "σ = " + Math.Round(γx, 4).ToString();
        }
    }
}