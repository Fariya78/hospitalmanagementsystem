using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace hospitalmanagementsystem
{
    public partial class diagnostic : Form
    {
        public diagnostic()
        {
            InitializeComponent();
        }
        
        
        diagnosis ad = new diagnosis();
        

        private void diagnostic_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = ad.disalldiagnosis();
            gridview();
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox8.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            //{
            ad.dno = textBox1.Text;
            ad.id = textBox8.Text;
            ad.name = textBox2.Text;
            ad.symp = textBox3.Text;
            ad.diag = textBox4.Text;
            ad.medic = textBox5.Text;
            ad.room = textBox6.Text;
            ad.payment = textBox7.Text;
            //    ad.adddiagnosis();

            //    cleardata();
            //    dataGridView1.DataSource = ad.dispalydiagnosis();
            //    dataGridView2.DataSource = ad.disalldiagnosis();
            //    gridview();
            //}
            //else { MessageBox.Show("diagnosis not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //BLL obj = new BLL();
            //obj.Insertdiagnosis(txtPatientId.Text, txtPatientName.Text);

        }
        public void cleardata()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ad.dno = textBox1.Text;
            //ad.id = textBox8.Text;
            //ad.name = textBox2.Text;
            //ad.symp = textBox3.Text;
            //ad.diag = textBox4.Text;
            //ad.medic = textBox5.Text;
            //ad.room = textBox6.Text;
            //ad.payment = textBox7.Text;
            //ad.updiagnosis();
            
            //cleardata();
            //gridview();
            //dataGridView1.DataSource = ad.dispalydiagnosis();
            //dataGridView2.DataSource = ad.disalldiagnosis();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ad.id = textBox8.Text;
            ad.dispalydiagnosis();
            gridview();
            dataGridView1.DataSource = ad.dispalydiagnosis();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            label9.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            label10.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label11.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label12.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            label15.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ad.dno = textBox1.Text;
            ad.deletediagnosis();

            gridview();
            dataGridView1.DataSource = ad.dispalydiagnosis();
            cleardata();

            dataGridView2.DataSource = ad.disalldiagnosis();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            label9.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            label10.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            label11.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            label12.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            label15.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label8.Text + "\n \n \n \n \n \n \n \n \n " + label9.Text + "\n" + label10.Text + "\n" + label11.Text + "\n" + label12.Text + "\n" + label15.Text, new Font("Century Gothic", 24, FontStyle.Regular), Brushes.Black, new Point(230));
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        public void gridview()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            ad.dno = textBox1.Text;
            ad.id = textBox8.Text;
            ad.name = textBox2.Text;
            ad.symp = textBox3.Text;
            ad.diag = textBox4.Text;
            ad.medic = textBox5.Text;
            ad.room = textBox6.Text;
            ad.payment = textBox7.Text;
        }
        //BLL obj = new BLL();
        //obj.Insertdiagnosis(txtPatientId.Text, txtPatientName.Text);
        private void Updatebutton2_Click(object sender, EventArgs e)
        {
            ad.dno = textBox1.Text;
            ad.id = textBox8.Text;
            ad.name = textBox2.Text;
            ad.symp = textBox3.Text;
            ad.diag = textBox4.Text;
            ad.medic = textBox5.Text;
            ad.room = textBox6.Text;
            ad.payment = textBox7.Text;
            BLL obj = new BLL();
            obj.updatediagnosis(ad.dno, ad.id, ad.name, ad.symp, ad.diag, ad.medic, ad.room, ad.payment);
            //ad.updiagnosis();

            //cleardata();
            //gridview();
            //dataGridView1.DataSource = ad.dispalydiagnosis();
            //dataGridView2.DataSource = ad.disalldiagnosis();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
