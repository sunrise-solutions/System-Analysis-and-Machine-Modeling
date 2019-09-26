using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distributions
{
    public partial class MainForm : Form
    {
        const int N = 100000;
        const int countOfIntervals = 20;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateDistributionEstimates(List<double> sequence, out double Mx, out double Dx, out double γx)
        {
            double sum = 0, sumD = 0;

            foreach (double x in sequence)
            {
                sum += x;
            }
            Mx = sum / N;

            foreach (double x in sequence)
            {
                sumD += (x - Mx) * (x - Mx);
            }
            Dx = sumD / N;
            γx = Math.Sqrt(Dx);
        }
    }
}
