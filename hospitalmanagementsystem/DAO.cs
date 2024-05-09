using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hospitalmanagementsystem
{
    public class DAO
    {
       public SqlConnection conc = new SqlConnection("Data Source=DESKTOP-MI7L8CV\\SQLEXPRESS;Initial Catalog=hospitalmanagementsystem;Integrated Security=True");
        public DataTable dt;
        #region doctor

        public void insert_doctor(string query)
        {
            
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        public void update_doctor(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_doctor(string query)
        {
           
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            
           
        }
        public void delete_doctor(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion

        #region paient

        public void insert_patient(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_patient(string query)
        {

            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_patient(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            
        }
        public void delete_patient(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion

        #region diagnosis

        public void insert_diagnosis(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_diagnosis(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_diagnosis(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            
        }
        public void delete_diagnosis(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_onediagnosis(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            
        }


        

        #endregion

        #region room
        public void insert_room(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_room(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_room(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            
        }
        public void delete_room(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion 

        #region staffsmain
        public void insert_staffsmain(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_staffsmain(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_staffsmain(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);   
        }
        public void delete_staffsmain(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion

        #region payment
        public void insert_payment(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_payment(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_payment(string query)
        {

            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);          
        }
        public void delete_payment(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion

        #region login

        public DataTable login_doctor(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable login_staff(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        #endregion 

        #region complains

        public void add_complain(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
      

        public void update_complain(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_complains(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt); 
        }
        public void delete_complain(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion

        #region appointments

        public void insert_appointment(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_appointment(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void delete_appointment(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_appointment(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
        }


        #endregion

        #region staff

        public void insert_staff(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_staff(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_staff(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
        }
        public void delete_staff(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }

        #endregion

        #region medicine

        public void insert_medicine(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void update_medicine(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }
        public void display_allmedicine(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
        }
        public void display_onemedicine(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conc);
            dt = new DataTable();
            adap.Fill(dt);
        }
        public void delete_medicine(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conc);
            conc.Open();
            cmd.ExecuteNonQuery();
            conc.Close();
        }


        #endregion
    }
}
