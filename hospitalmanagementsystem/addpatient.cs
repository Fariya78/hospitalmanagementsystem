using BusinessLogicLayer;
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
    public partial class addpatient : Form
    {
        public addpatient()
        {
            InitializeComponent();
        }
        patient ip = new patient();
       

        private void button1_Click(object sender, EventArgs e)
        {
            ip.id = textBox7.Text;
            ip.pname = textBox1.Text;
            ip.page = textBox2.Text;
            ip.pgender = comboBox2.Text;
            ip.paddress = textBox4.Text;
            ip.pphone = textBox5.Text;
            ip.pbgroup = comboBox1.Text;
            BLL obj = new BLL();
            obj.Insertpatient( ip.pname, ip.page, ip.pgender, ip.paddress, ip.pphone, ip.pbgroup);
            MessageBox.Show("Insert");
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ip.id = textBox7.Text;
            ip.pname = textBox1.Text;
            ip.page = textBox2.Text;
            ip.pgender = comboBox2.Text;
            ip.paddress = textBox4.Text;
            ip.pphone = textBox5.Text;
            ip.pbgroup = comboBox1.Text;
            BLL obj = new BLL();
            obj.patientupdate( ip.id,ip.pname, ip.page, ip.pgender, ip.paddress, ip.pphone, ip.pbgroup);
            MessageBox.Show("update");
            //ip.updatepatient();

            //dataGridView1.DataSource = ip.displaypatient();
            //clear();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ip.displaypatient();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            ip.id = textBox7.Text;
            obj.patientdelete(ip.id);
            MessageBox.Show("delete");
            //ip.id = textBox7.Text;
            //ip.deletepatient();
           
            //dataGridView1.DataSource = ip.displaypatient();
            //clear();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

     
    }
}
