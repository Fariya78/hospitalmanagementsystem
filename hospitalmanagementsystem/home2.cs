using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public partial class home2 : Form
    {
        public home2()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            diagnostic d = new diagnostic();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            addcomplain ad = new addcomplain();
            ad.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            appointment a = new appointment();
            a.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {

            loginas la = new loginas();
            la.Show();
            this.Hide();
        }
    }
}
