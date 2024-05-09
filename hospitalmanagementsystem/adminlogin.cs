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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }
        loginadmin la = new loginadmin("Data Source=DESKTOP-DTL3QDI\\sQLEXPRESS01;Initial Catalog=hospitalmanagementsystem;Integrated Security=True");

    
            
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            //  la.logadmin(textBox1.Text, textBox2.Text);
            if (textBox1.Text == la.name && textBox2.Text == la.password)
            {
                home h1 = new home();
                h1.Show();
                this.Hide();
            }
            else { MessageBox.Show("Failed to login"); }
            
}

        private void button2_Click(object sender, EventArgs e)
        {
            loginas la = new loginas();
            la.Show();
            this.Hide();
        }


        

       
    
       
    }
}
