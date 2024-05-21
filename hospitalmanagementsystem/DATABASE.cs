using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospitalmanagementsystem
{
    public partial class DATABASE : Form
    {
        public DATABASE()
        {
            InitializeComponent();
        }

        private void DATABASE_Load(object sender, EventArgs e)
        {

        }
        private void LOGIN_CLICK(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + servertxt.Text + ";Initial Catalog = " + db_text.Text + "; User ID = " + serveridtxt.Text + ";" + "Password = " + db_passtxt.Text + ";";


            string sqlQuery = "select count (*) from databasee where Userr='" + usernametxt.Text + "'and password='" + passwordtxt.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    MessageBox.Show("Successful");
                    loginas f2 = new loginas();
                    f2.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    throw;
                }

            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void db_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void db_pass(object sender, EventArgs e)
        {

        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}



