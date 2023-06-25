using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTBINFU
{
    public partial class TASKS : UserControl
    {
        public TASKS()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1 .BringToFront ();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront();
            panel1.Visible = false;
            panel2.Visible = false;
        }
    }
}
