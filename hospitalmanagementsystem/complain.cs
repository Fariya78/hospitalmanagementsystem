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
    public partial class complain : Form
    {
        public complain()
        {
            InitializeComponent();
        }
        complains c = new complains();

      
       

       

        public void gridview()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.id = textBox1.Text;
            c.deletecomplain();
            dataGridView1.DataSource = c.displaycomplain();
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.id = textBox1.Text;
            c.solution = comboBox1.Text;

            c.updatecomplain();
            dataGridView1.DataSource = c.displaycomplain();
            
        }

        private void complain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.displaycomplain();
            gridview();
        }
    }
}
