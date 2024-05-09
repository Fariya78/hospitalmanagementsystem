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
    public partial class medicine : Form
    {
        public medicine()
        {
            InitializeComponent();
        }
        medicines md = new medicines();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {

                md.id = textBox1.Text;
                md.date = textBox2.Text;
                md.medname = textBox3.Text;
                md.quantity = textBox4.Text;
                md.payment = textBox5.Text;
                md.company = textBox6.Text;
                md.seller = textBox7.Text;
                md.status = textBox8.Text;

                md.insertmedicine();
                cleardata();
                dataGridView1.DataSource = md.displayonemedicine();
                dataGridView2.DataSource = md.displaymedicine();
            }
            else { MessageBox.Show("medicine not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            md.id = textBox1.Text;
            md.date = textBox2.Text;
            md.medname = textBox3.Text;
            md.quantity = textBox4.Text;
            md.payment = textBox5.Text;
            md.company = textBox6.Text;
            md.seller = textBox7.Text;
            md.status = textBox8.Text;

            md.updatemedicine();
            cleardata();
            dataGridView1.DataSource = md.displayonemedicine();
            dataGridView2.DataSource = md.displaymedicine();
        }

        private void medicine_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = md.displaymedicine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            md.id = textBox1.Text;

            md.displayonemedicine();
            cleardata();
            dataGridView1.DataSource = md.displayonemedicine();
            dataGridView2.DataSource = md.displaymedicine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            md.id = textBox1.Text;
            md.deletemedicine();
            cleardata();
            dataGridView1.DataSource = md.displayonemedicine();
            dataGridView2.DataSource = md.displaymedicine();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
