using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class appointments
    {
        public string appid;
        public string pid;
        public string pname;
        public string doc;
        public string time;
        public string date;

        public void addapppointment()
        {
            string query = "insert into appointment values('" + appid + "', '" + pid + "','" + pname + "','" + doc + "','" + time + "','" + date + "')";
            DAO d = new DAO();
            d.insert_appointment(query);
            MessageBox.Show(" appointment inserted", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void updateappointment()
        {
            string query = "update appointment set PID = '" + pid + "', PNAME = '" + pname + "', DNAME = '" + doc + "', TIMES = '" + time + "', DATES = '" + date + "' where    AID = '" + appid + "' ";
            DAO d = new DAO();
            d.update_complain(query);
            MessageBox.Show(" appointment updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void deleteappointment()
        {
            string query = "delete  from appointment where AID = '" + appid + "'";
            DAO d = new DAO();
            d.delete_appointment(query);
            MessageBox.Show("appointment deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DataTable displayappointment()
        {
            string query = "select * from appointment";
            DAO d = new DAO();
            d.display_appointment(query);
            return d.dt;

        }


    }
}
