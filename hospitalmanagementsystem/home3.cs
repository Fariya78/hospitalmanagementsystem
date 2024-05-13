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
    public partial class home3 : Form
    {
        public home3()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            addrooms r1 = new addrooms();
            r1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addpatient ap = new addpatient();
            ap.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            appointment a = new appointment();
            a.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            complain c1 = new complain();
            c1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            payment p1 = new payment();
            p1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void home3_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginas la = new loginas();
            la.Show();
            this.Hide();
        }
    }
}
