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
            button1.Text = "I'm clicked!";
            button1.BackColor = Color.Aqua;
        }
    }
}
