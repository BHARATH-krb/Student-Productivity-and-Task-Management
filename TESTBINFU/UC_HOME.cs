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
    public partial class UC_HOME : UserControl
    {
        public UC_HOME()
        {
            InitializeComponent();
        }

        private void LABLEHELLO_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRating1_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
           
        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/gdg-updb-udv");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/eyv-eabi-ifv");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/upj-rrpf-vwb");
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/kkq-wgju-mmo");
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/pqg-zczr-wmb");
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/ciq-sdmz-wbw");
        }

        private void bunifuLabel14_Click(object sender, EventArgs e)
        {
            bunifuLabel14.Text = System.DateTime.Now.ToString();
        }

        private void UC_HOME_Load(object sender, EventArgs e)
        {
            bunifuLabel14.Text = System.DateTime.Now.ToString();
            bunifuPanel3.Visible = false;

        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            bunifuPanel3.Visible = true;
            bunifuPanel3.BringToFront();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuPanel3 .Visible = false;
            bunifuPanel3.SendToBack ();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attendence saved");
        }
    }
}
