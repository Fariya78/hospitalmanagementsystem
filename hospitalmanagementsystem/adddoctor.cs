using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace hospitalmanagementsystem
{
    public partial class adddoctor : Form
    {
        public adddoctor()
        {
            InitializeComponent();
        }
        doctor di = new doctor();
            //("Data Source=DESKTOP-DTL3QDI\\sQLEXPRESS01;Initial Catalog=hospitalmanagementsystem;Integrated Security=True");
       
       

        private void adddoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //di.id = textBox8.Text;
            //di.name = textBox1.Text;
            //di.age =textBox3.Text;
            //di.gender = comboBox2.Text;
            //di.phone = textBox4.Text;
            //di.password = textBox5.Text;
            //di.address = textBox6.Text;
            //di.email = textBox7.Text;

            //di.updaterecord();
            //cleardata();
            //dataGridView1.DataSource = di.displaydata();
            di.id = textBox8.Text;
            di.name = textBox1.Text;
            di.age = textBox3.Text;
            di.gender = comboBox2.Text;
            di.phone = textBox4.Text;
            di.password = textBox5.Text;
            di.address = textBox6.Text;
            di.email = textBox7.Text;
            BLL obj = new BLL();
            obj.UpdateDoctor(di.id, di.name, di.age, di.gender, di.phone, di.password, di.address, di.email);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = di.displaydata();
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            di.id = textBox8.Text;
            di.deletedata();
            cleardata();
            dataGridView1.DataSource = di.displaydata();
        }
        public void cleardata() {
            textBox1.Clear();
            
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void INSERT_button1_Click(object sender, EventArgs e)
        {
            /* if (textBox1.Text != "" && comboBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
             {
                 di.id = textBox8.Text;
                 di.name = textBox1.Text;
                 di.age = textBox3.Text;
                 di.gender = comboBox2.Text;
                 di.phone = textBox4.Text;
                 di.password = textBox5.Text;
                 di.address = textBox6.Text;
                 di.email = textBox7.Text;

                 di.insertrecord();
                 cleardata();
                 dataGridView1.DataSource = di.displaydata();


             }
             else { MessageBox.Show("doctor not inserted", "NOT INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Error); }
         -----------------------------------------------------------------------------------------*/

            di.id = textBox8.Text;
            di.name = textBox1.Text;
            di.age = textBox3.Text;
            di.gender = comboBox2.Text;
            di.phone = textBox4.Text;
            di.password = textBox5.Text;
            di.address = textBox6.Text;
            di.email = textBox7.Text;
            BLL obj = new BLL();
            obj.sp_InsertDoctor(di.name,di.age, di.gender, di.phone, di.password, di.address, di.email);
        }

    }
}
