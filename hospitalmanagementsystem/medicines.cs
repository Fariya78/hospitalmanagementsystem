using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class medicines
    {
        public string id;
        public string date;
        public string medname;
        public string quantity;
        public string payment;
        public string company;
        public string seller;
        public string status;

        public void insertmedicine()
        {
            string query = "insert into medicine values('" + id + "', '" + date + "','" + medname + "','" + quantity + "','" + payment + "','" + company + "','" + seller + "','" + status + "')";
            DAO d = new DAO();
            d.insert_medicine(query);
            MessageBox.Show("medicine inserted", "INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void updatemedicine()
        {
            string query = "update medicine set dates = '" + date + "', MED_name  = '" + medname + "', quantity = '" + quantity + "', payment = '" + payment + "', company = '" + company + "', seller = '" + seller + "', statuss = '" + status + "'where MED_id = '" + id + "' ";
            DAO d = new DAO();
            d.update_medicine(query);
            MessageBox.Show("medicine Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public DataTable displaymedicine()
        {
            string query = "select * from medicine";
            DAO d = new DAO();
            d.display_allmedicine(query);
            return d.dt;

        }
        public DataTable displayonemedicine()
        {
            string query = "select * from medicine where MED_id = '" + id + "'";
            DAO d = new DAO();
            d.display_onemedicine(query);
            return d.dt;
        }
        public void deletemedicine()
        {
            string query = "delete  from medicine where MED_id = '" + id + "'";
            DAO d = new DAO();
            d.delete_medicine(query);
            MessageBox.Show("medicine deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
