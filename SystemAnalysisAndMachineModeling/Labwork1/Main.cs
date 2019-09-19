using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labwork1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (ValueChecking.IsValid(tbM.Text) && ValueChecking.IsValid(tbA.Text) && ValueChecking.IsValid(tbR0.Text))
            {
                int m = Convert.ToInt32(tbM.Text);
                int a = Convert.ToInt32(tbA.Text);
                int r0 = Convert.ToInt32(tbR0.Text);

                if (m > a)
                {
                    Calculation calculation = new Calculation(m, a, r0);
                    Calculation.DoCalculations();
                }
                else
                {
                    MessageBox.Show("m should be greater than a!");
                }
            }
            else
            {
                MessageBox.Show("All the values should be positive integers!");
            }
        }
    }
}
