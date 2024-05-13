using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public partial class addrooms : Form
    {
        public addrooms()
        {
            InitializeComponent();
        }
        rooms ar = new rooms();
        private void insert_Click(object sender, EventArgs e)
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

        private void update_click(object sender, EventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {

            ar.rid = textBox4.Text;
            ar.deleteroom();



            cleardata();

            dataGridView1.DataSource = ar.displayroom();
        }

        private void display_click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ar.displayroom();
        }
    }
}
