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
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }
        appointments a1 = new appointments();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                a1.appid = textBox1.Text;
                a1.pid = textBox2.Text;
                a1.pname = textBox3.Text;
                a1.doc = textBox4.Text;
                a1.time = textBox5.Text;
                a1.date = textBox6.Text;

                a1.addapppointment();
                dataGridView1.DataSource = a1.displayappointment();
                gridview();
                cleardata();
            }

        }
        public void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1.appid = textBox1.Text;
            a1.pid = textBox2.Text;
            a1.pname = textBox3.Text;
            a1.doc = textBox4.Text;
            a1.time = textBox5.Text;
            a1.date = textBox6.Text;

            a1.updateappointment();
            dataGridView1.DataSource = a1.displayappointment();
            gridview();
            cleardata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a1.appid = textBox1.Text;
            a1.deleteappointment();
            dataGridView1.DataSource = a1.displayappointment();
            gridview();
            cleardata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a1.displayappointment();
            gridview();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        public void gridview()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;          
        }

        private void appointment_Load(object sender, EventArgs e)
        {
            
        }



    }
}
