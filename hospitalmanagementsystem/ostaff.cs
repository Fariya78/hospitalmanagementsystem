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
    public partial class ostaff : Form
    {
        public ostaff()
        {
            InitializeComponent();
        }
        staffs s = new staffs();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                s.id = textBox1.Text;
                s.name = textBox2.Text;
                s.gender = comboBox1.Text;
                s.position = textBox3.Text;
                s.address = textBox4.Text;
                s.phone = textBox5.Text;

                s.addstaff();
                dataGridView1.DataSource = s.displaystaff();
                gridview();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.id = textBox1.Text;
            s.name = textBox2.Text;
            s.gender = comboBox1.Text;
            s.position = textBox3.Text;
            s.address = textBox4.Text;
            s.phone = textBox5.Text;

            s.updatestaff();
            dataGridView1.DataSource = s.displaystaff();
            gridview();
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s.displaystaff();
            gridview();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.id = textBox1.Text;
            s.deletestaff();
            dataGridView1.DataSource = s.displaystaff();
            gridview();
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
        }
        public void gridview()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                s.id = textBox1.Text;
                s.name = textBox2.Text;
                s.gender = comboBox1.Text;
                s.position = textBox3.Text;
                s.address = textBox4.Text;
                s.phone = textBox5.Text;

                s.addstaff();
                dataGridView1.DataSource = s.displaystaff();
                gridview();
                clear();

            }
            else { MessageBox.Show("staff not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void update_Click(object sender, EventArgs e)
        {
            s.id = textBox1.Text;
            s.name = textBox2.Text;
            s.gender = comboBox1.Text;
            s.position = textBox3.Text;
            s.address = textBox4.Text;
            s.phone = textBox5.Text;

            s.updatestaff();
            dataGridView1.DataSource = s.displaystaff();
            gridview();
            clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            s.id = textBox1.Text;
            s.deletestaff();
            dataGridView1.DataSource = s.displaystaff();
            gridview();
            clear();
        }

        private void display_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = s.displaystaff();
            gridview();
        }
    }
}
