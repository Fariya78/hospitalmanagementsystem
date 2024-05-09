using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class doctor
    {
        public string id;
        public string name;
        public string age;
        public string gender;
        public string phone;
        public string password;
        public string address;
        public string email;

       

        public void insertrecord()
        {
            string query = "insert into doctor values('" + id + "', '" + name + "','" + age + "','" + gender + "','" + phone + "','" + password + "','" + address + "','" + email + "')";
            DAO d = new DAO();
            d.insert_doctor(query);
            MessageBox.Show("Doctor inserted", "INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Information);


            
        }
        public void updaterecord()
        {
           

            string query = "update doctor set DOC_name = '" + name + "', DOC_age = '" + age + "', DOC_genger = '" + gender + "', DOC_phoneno = '" + phone + "', DOC_password = '" + password + "', DOC_address = '" + address + "', DOC_email = '" + email + "'where DOC_id = '" + id + "' ";
           DAO d = new DAO();
            d.update_doctor(query); 
            MessageBox.Show("doctor Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        public DataTable displaydata()
        {
            string query = "select * from doctor";
            DAO d = new DAO();
            d.display_doctor(query);
            return d.dt;
            
             


        }

        public void deletedata()
        {
            string query = "delete  from doctor where DOC_id = '" + id + "'";
            DAO d = new DAO();
            d.delete_doctor(query);
            MessageBox.Show("doctor deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

        }
        
       
    }
}
