using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hospitalmanagementsystem
{
    public class loginadmin
    {
        public string name = "admin";
        public string password = "admin123";
         
        SqlConnection conc;

        public loginadmin(string cstring)
        {
            this.conc = new SqlConnection(cstring);

        }
        public void logadmin(string nm, string pass)
        {
            this.name = nm;
            this.password = pass;
           
        }

    }
}
