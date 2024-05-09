using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class payments
    {
        public int challan;
        public string pname;
        public int dfee;
        public int rcharges;
        public int acharges;
        public int tcharges;

      
        public void paymentadd()
        {

       string query = "insert into payment values('" + challan + "','" + pname + "','" + dfee + "','" + rcharges + "','" + acharges + "','" + tcharges + "')";
       DAO d = new DAO();
       d.insert_payment(query);
       MessageBox.Show("payment inserted", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }
        public void uppayment()
        {

            string query = "update payment set NAMES= '" + pname + "', DOC_fee = '" + dfee + "', ROOM_charges = '" + rcharges + "', ADDITIONAL_charges = '" + acharges + "', TOTAL_charges = '" + tcharges + "' where pay_id = '" + challan + "' ";
            DAO d = new DAO();
            d.update_payment(query);
            MessageBox.Show("payment Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public DataTable displaydata()
        {
            string query = "select * from payment";
            DAO d = new DAO();
            d.display_payment(query);
            return d.dt;

        }
        public void delpayment()
        {
            string query = "delete  from payment where PAY_id = '" + challan + "'";
            DAO d = new DAO();
            d.delete_payment(query);
            MessageBox.Show("payment deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int addtion()
        {

            tcharges =  dfee + rcharges + acharges;
            return tcharges;
        }

        
    }
}
