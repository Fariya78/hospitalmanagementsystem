using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class staffs 
    {
        public string id;
        public string name;
        public string gender;
        public string phone;
        public string position;
        public string address;

        public void addstaff()
        {
            string query = "insert into ostaff values('" + id + "','" + name + "','" + gender + "','" + position + "','" + address + "','" + phone + "')";
            DAO d = new DAO();
            d.insert_staff(query);
            MessageBox.Show("staff inserted", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void updatestaff()
        {
            string query = "update ostaff set STAFF_NAME = '" + name + "', STAFF_GENDER = '" + gender + "', POSITION = '" + position + "', ADDRESSS = '" + address + "', PHONEE = '" + phone + "'where SID = '" + id + "' ";
            DAO d = new DAO();
            d.update_staff(query);
            MessageBox.Show("staff Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //polymorphism
        public virtual DataTable displaystaff()
        {
            string query = "select * from Ostaff";
            DAO d = new DAO();
            d.display_staff(query);
            return d.dt;

        }
        public void deletestaff()
        {
            string query = "delete  from Ostaff where SID = '" + id + "'";
            DAO d = new DAO();
            d.delete_staff(query);
            MessageBox.Show("staff deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
