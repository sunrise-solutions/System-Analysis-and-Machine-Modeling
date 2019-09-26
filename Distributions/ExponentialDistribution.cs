﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distributions
{
    public partial class MainForm : Form
    {
        private void Button3_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(exMTextBox.Text);
            int coefficientA = Convert.ToInt32(exCoefficientATextBox.Text);
            int R0 = Convert.ToInt32(exR0TextBox.Text);

            Generator generator = new Generator(coefficientA, m, R0);
            List<double> sequence = new List<double>();

            double λ = double.Parse(exλTextBox.Text);
            sequence = Distribution.Exponential(generator.GetNext().Take(N), λ);

            CalculateExponentialDistributionEstimates(λ);
        }

        private void CalculateExponentialDistributionEstimates(double λ)
        {
            double Mx = 1 / λ;
            double Dx = 1 / Math.Pow(λ, 2);
            double γx = Math.Sqrt(Dx);

            exMxValueLabel.Text = Math.Round(Mx, 5).ToString();
            exDxValueLabel.Text = Math.Round(Dx, 4).ToString();
            exγxValueLabel.Text = Math.Round(γx, 4).ToString();
        }
    }
}