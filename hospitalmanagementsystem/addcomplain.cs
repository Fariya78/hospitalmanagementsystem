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
    public partial class addcomplain : Form
    {
        public addcomplain()
        {
            InitializeComponent();
        }
        complains c1 = new complains();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                c1.name = textBox1.Text;
                c1.post = textBox2.Text;
                c1.topic = textBox3.Text;
                c1.description = textBox4.Text;
                c1.phoneno = textBox5.Text;

                c1.addcomplain();
                clear();
            }
            else { MessageBox.Show("complain not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
