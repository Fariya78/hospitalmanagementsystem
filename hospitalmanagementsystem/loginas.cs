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
    public partial class loginas : Form
    {
        public loginas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginstaff ls = new loginstaff();
            ls.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logindoctor ld = new logindoctor();
            ld.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginstaff ls = new loginstaff();
            ls.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            adminlogin al = new adminlogin();
            al.Show();
            this.Hide();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            logindoctor ld = new logindoctor();
            ld.Show();
            this.Hide();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            loginstaff ls = new loginstaff();
            ls.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
