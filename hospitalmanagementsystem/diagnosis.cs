using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class diagnosis
    {
        public string dno;
        public string id;
        public string name;
        public string symp;
        public string diag;
        public string medic;
        public string room;
        public string payment;

   

        //public void adddiagnosis()
        //{

        //    string query = "insert into diagnosis values('" + dno + "','" + id + "','" + name + "','" + symp + "','" + diag + "','" + medic + "','" + room + "','" + payment + "')";
        //    DAO d = new DAO();
        //    d.insert_diagnosis(query);
        //    MessageBox.Show("DIAGNOSIS inserted", "INSERTED", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}
        //public void updiagnosis()
        //{

        //    string query = "update diagnosis set PATIENT_ids = '" + id + "', PATIENT_names = '" + name + "', SYMPTOMS = '" + symp + "', DIAGNOSIS = '" + diag + "', MEDICINE = '" + medic + "', DIAGNOSIS_room = '" + room + "', DIAG_payment = '" + payment + "'where DIAGNOSIS_id = '" + dno + "' ";
        //    DAO d = new DAO();
        //    d.update_diagnosis(query);
        //    MessageBox.Show("DIAGNOSIS Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //public DataTable dispalydiagnosis()
        //{
        //    string query = "select * from diagnosis where PATIENT_ids = '" + id + "' ";
        //    DAO d = new DAO();
        //    d.display_onediagnosis(query);
            
        //    return d.dt;


        //}
        //public void deletediagnosis()
        //{
        //    string query = "delete  from diagnosis where DIAGNOSIS_id = '" + dno + "'";
        //    DAO d = new DAO();
        //    d.delete_diagnosis(query);
        //    MessageBox.Show("diagnosis deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        //}
        public DataTable disalldiagnosis()
        {
            string query = "select * from diagnosis";
            DAO d = new DAO();
            d.display_diagnosis(query);
            return d.dt;
        }
    }
}
