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
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }
        rooms ar = new rooms();
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox2.Text != "" && comboBox2.Text != "" && textBox4.Text != "")
            {
                ar.rid = textBox4.Text;
                ar.rname = textBox1.Text;
                ar.id = textBox3.Text;
                ar.name = textBox2.Text;
                ar.ward = comboBox1.Text;
                ar.status = comboBox2.Text;

                ar.insertroom();
                
                cleardata();
                dataGridView1.DataSource = ar.displayroom();

            }
            else { MessageBox.Show("room not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }
        public void cleardata()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ar.rid = textBox4.Text;
            ar.rname = textBox1.Text;
            ar.id = textBox3.Text;
            ar.name = textBox2.Text;
            ar.ward = comboBox1.Text;
            ar.status = comboBox2.Text;
            
            ar.updateroom();
            
            cleardata();
            dataGridView1.DataSource = ar.displayroom();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ar.displayroom();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.rid = textBox4.Text;
            ar.deleteroom();
            
           
            cleardata();

            dataGridView1.DataSource = ar.displayroom();
        }


       
    }
}
