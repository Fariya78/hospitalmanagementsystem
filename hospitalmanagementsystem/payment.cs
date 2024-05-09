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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        payments p = new payments();
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                p.challan = Convert.ToInt32(textBox1.Text);
                p.pname = textBox2.Text;
                p.dfee = Convert.ToInt32(textBox3.Text);
                p.rcharges = Convert.ToInt32(textBox4.Text);
                p.acharges = Convert.ToInt32(textBox5.Text);
                p.tcharges = Convert.ToInt32(textBox6.Text);
                gridview();
                p.paymentadd();
                
                
                cleardata();
                dataGridView1.DataSource = p.displaydata();
            }
            else { MessageBox.Show("payment not inserted", "PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.challan = Convert.ToInt32(textBox1.Text);
            p.pname = textBox2.Text;
            p.dfee = Convert.ToInt32(textBox3.Text);
            p.rcharges = Convert.ToInt32(textBox4.Text);
            p.acharges = Convert.ToInt32(textBox5.Text);
            p.tcharges = Convert.ToInt32(textBox6.Text);

            p.uppayment();
            gridview();
            cleardata();
            dataGridView1.DataSource = p.displaydata();
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

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.displaydata();
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

        private void button6_Click(object sender, EventArgs e)
        {

            p.dfee = Convert.ToInt32(textBox3.Text);
            p.rcharges = Convert.ToInt32(textBox4.Text);
            p.acharges = Convert.ToInt32(textBox5.Text);
            textBox6.Text = Convert.ToString(p.addtion());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.challan = Convert.ToInt32(textBox1.Text);
          
            p.delpayment();
            
            gridview();
            cleardata();

            dataGridView1.DataSource = p.displaydata();
        }
        public void gridview()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label7.Text + "\n\n\n\n\n \n\n\n " + label1.Text + "\t" + textBox1.Text + "\n" + label2.Text + "\t" + textBox2.Text + "\n" + label3.Text + "\t" + textBox3.Text + "\n" + label4.Text + "\t" + textBox4.Text + "\n" + label5.Text + "\t" + textBox5.Text + "\n" + label6.Text + "\t" + textBox6.Text, new Font("Century Gothic", 24, FontStyle.Regular), Brushes.Black, new Point(230));

        }
    }
}
