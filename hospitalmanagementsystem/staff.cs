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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        staffsmain ins = new staffsmain();
            //("Data Source=DESKTOP-DTL3QDI\\sQLEXPRESS01;Initial Catalog=hospitalmanagementsystem;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                ins.id = textBox1.Text;
                ins.name = textBox2.Text;
                ins.gender = comboBox1.Text;
                ins.email = textBox3.Text;
                ins.position = textBox4.Text;
                ins.address = textBox5.Text;
                ins.password = textBox6.Text;
                ins.phone = textBox7.Text;

                ins.addstaffs();
                dataGridView1.DataSource = ins.displaystaff();
                clear();

            }
            else { MessageBox.Show("staff not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }
 

            
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ins.id = textBox1.Text;
            ins.name = textBox2.Text;
            ins.gender = comboBox1.Text;
            ins.email = textBox3.Text;
            ins.position = textBox4.Text;
            ins.address = textBox5.Text;
            ins.password = textBox6.Text;
            ins.phone = textBox7.Text;

            ins.upsdatetaff();
            dataGridView1.DataSource = ins.displaystaff();
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ins.displaystaff();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ins.id = textBox1.Text;
            ins.deletestaffs();
            dataGridView1.DataSource = ins.displaystaff();
            clear();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
