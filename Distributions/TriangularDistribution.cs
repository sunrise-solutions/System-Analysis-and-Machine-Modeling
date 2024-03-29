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
        private void Button5_Click(object sender, EventArgs e)
        {
            if (!ValueChecker.IsValid(trMTextBox.Text) || !ValueChecker.IsValid(trCoefficientATextBox.Text) || !ValueChecker.IsValid(trR0TextBox.Text))
            {
                MessageBox.Show("All the values should be positive integers!");
            }

            int m = Convert.ToInt32(trMTextBox.Text);
            int coefficientA = Convert.ToInt32(trCoefficientATextBox.Text);
            int R0 = Convert.ToInt32(trR0TextBox.Text);

            Generator generator = new Generator(coefficientA, m, R0);
            List<double> sequence = new List<double>();

            double a = double.Parse(trATextBox.Text);
            double b = double.Parse(trBTextBox.Text);
            sequence = Distribution.Triangular(generator.GetNext().Take(N), a, b);

            CalculateTriangularDistributionEstimates(sequence, a, b);
        }

        private void CalculateTriangularDistributionEstimates(List<double> sequence, double a, double b)
        {
            double Mx, Dx, γx;
            CalculateDistributionEstimates(sequence, out Mx, out Dx, out γx);
            
            trMxValueLabel.Text = Math.Round(Mx, 5).ToString();
            trDxValueLabel.Text = Math.Round(Dx, 4).ToString();
            trγxValueLabel.Text = Math.Round(γx, 4).ToString();
        }
    }
}