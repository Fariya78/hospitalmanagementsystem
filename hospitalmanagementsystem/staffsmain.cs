using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
   public class staffsmain : staffs
    {
        
        public string email;      
        public string password;
  
        public void addstaffs()
        {
            
            string query = "insert into staff values('" + id + "','" + name + "','" + gender + "','" + email + "','" + position + "','" + address + "','" + password + "','" + phone + "')";
            DAO d = new DAO();
            d.insert_staffsmain(query);
            MessageBox.Show("staff inserted", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void upsdatetaff()
        {
            string query = "update staff set STAFF_name = '" + name + "', STAFF_gender = '" + gender + "', STAFF_email = '" + email + "', STAFF_position = '" + position + "', STAFF_address = '" + address + "', STAFF_password = '" + password + "', STAFF_phoneno = '" + phone + "'where STAFF_id = '" + id + "' ";
            DAO d = new DAO();
            d.update_staffsmain(query);
            MessageBox.Show("staff Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override DataTable displaystaff()
        {
            string query = "select * from staff";
            DAO d = new DAO();
            d.display_staffsmain(query);

            return d.dt;
    }
        public void deletestaffs()
        {
            string query = "delete  from staff where STAFF_id = '" + id + "'";          
            DAO d = new DAO();
            d.delete_staffsmain(query);
            MessageBox.Show("staff deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
