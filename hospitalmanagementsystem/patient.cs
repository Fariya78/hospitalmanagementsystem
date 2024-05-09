using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class patient
    {
        public string id;
        public string pname;
        public string page;
        public string pgender;
        public string paddress;
        public string pphone;
        public string pbgroup;

        

        public void enterpatient()
        {
            string query = "insert into patient values('" + id + "','" + pname + "','" + page + "','" + pgender + "','" + paddress + "','" + pphone + "','" + pbgroup + "')";
            DAO d = new DAO();
            d.insert_patient(query);
            MessageBox.Show("Patient inserted", "INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        public void updatepatient()
        {
            string query = "update patient set PATIENT_name = '" + pname + "', PATIENT_age = '" + page + "', PATIENT_gender = '" + pgender + "', PATIENT_address = '" + paddress + "', PATIENT_phoneno = '" + pphone + "', PATIENT_bloodgroup = '" + pbgroup + "' where PATIENT_id = '" + id + "' ";
                DAO d = new DAO();
            d.update_patient(query);
            MessageBox.Show("Patient UPDATED ", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public DataTable displaypatient()
        {
            string query = "select * from patient";   
            DAO d = new DAO();
            d.display_doctor(query);
            return d.dt;
        }

        public void deletepatient()
        {
            string query = "delete  from patient where PATIENT_id = '" + id + "'";
            DAO d = new DAO();
            d.delete_patient(query);
            MessageBox.Show("patient deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
