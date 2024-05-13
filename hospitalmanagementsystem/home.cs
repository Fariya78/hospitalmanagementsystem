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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adddoctor ad = new adddoctor();
            ad.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addpatient ap = new addpatient();
            ap.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            diagnostic dia = new diagnostic();
            dia.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            addrooms r1 = new addrooms();
            r1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            staff st = new staff();
            st.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            payment p1 = new payment();
            p1.Show();
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ostaff os = new ostaff();
            os.Show();
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            complain c1 = new complain();
            c1.Show();
            
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            appointment a = new appointment();
            a.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            medicine m = new medicine();
            m.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginas la = new loginas();
            la.Show();
            this.Hide();
        }
    }
}
