using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hospitalmanagementsystem
{
    public class login
    {
        public string demail;
        public string dpassword;
        public bool check;

      

        public void doclogin()
        {
            

            string query = "select DOC_email,DOC_password from doctor where DOC_email='" + demail + "' and DOC_password='" + dpassword + "'";
            DAO d = new DAO();
            d.login_doctor(query);
            

            if (d.dt.Rows.Count > 0)
            {
                check = true;       
            }
            else { check = false; }
        }
        public void stafflogin()
        {
            string query = "select STAFF_email,STAFF_password from staff where STAFF_email='" + demail + "' and STAFF_password='" + dpassword + "'";
             DAO d = new DAO();
             d.login_staff(query);
                

            if (d.dt.Rows.Count > 0)
            {
                check = true;       
            }
            else { check = false; }
        
        }
    
    }
}
