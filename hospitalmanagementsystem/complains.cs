using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    class complains
    {
        public string name;
        public string post;
        public string topic;
        public string phoneno;
        public string description;
        public string solution;
        public string id;

        //SqlConnection conc;

        //public complains(string cstring)
        //{
        //    this.conc = new SqlConnection(cstring);
        //}
        public void addcomplain()
        {
            string query = "insert into complain (Names,POST,TOPIC,DESCRIPTIONS,PHONE) values('" + name + "','" + post + "','" + topic + "','" + description + "','" + phoneno + "')";
            DAO d = new DAO();
            d.add_complain(query);
            MessageBox.Show(" your complain have been submitted", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     

        public void updatecomplain()
        {
            string query = "update complain set SOLUTION = '" + solution + "' where COM_ID = '" + id + "' ";
            DAO d = new DAO();
            d.update_complain(query);
            MessageBox.Show(" Complain updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public DataTable displaycomplain()
        {
             string query = "select * from complain";
             DAO d = new DAO();
             d.display_complains(query);
             return d.dt;
             
        }
        public void deletecomplain()
        {
            string query = "delete  from complain where COM_ID = '" + id + "'";
            DAO d = new DAO();
            d.delete_complain(query);
            MessageBox.Show("complain deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
