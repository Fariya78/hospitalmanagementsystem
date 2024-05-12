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
    public partial class loginstaff : Form
    {
        public loginstaff()
        {
            InitializeComponent();
        }
        login ld1 = new login();

        private void button1_Click(object sender, EventArgs e)
        {

            ld1.demail = textBox1.Text;
            ld1.dpassword = textBox2.Text;

            ld1.stafflogin();
            if (ld1.check == true)
            {
                MessageBox.Show("successfully loggedin", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                home3 h3 = new home3();
                h3.Show();
                this.Hide();
            }


            else { MessageBox.Show("failed to login", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    

    private void button2_Click(object sender, EventArgs e)
        {
            loginas la = new loginas();
            la.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            ld1.demail = textBox1.Text;
            ld1.dpassword = textBox2.Text;

            ld1.stafflogin();
            if (ld1.check == true)
            {
                MessageBox.Show("successfully loggedin", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                home3 h3 = new home3();
                h3.Show();
                this.Hide();
            }


            else { MessageBox.Show("failed to login", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            loginas la = new loginas();
            la.Show();
            this.Hide();
        }
    }
}

