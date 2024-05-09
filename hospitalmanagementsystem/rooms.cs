using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagementsystem
{
    public class rooms
    {
        public string rname;
        public string id;
        public string name;
        public string ward;
        public string status;
        public string rid;

        

        public void insertroom()
        {

            string query = "insert into room values('" + rid + "','" + rname + "','" + id + "','" + name + "','" + ward + "','" + status + "')";
            DAO d = new DAO();
            d.insert_room(query);
            MessageBox.Show("room inserted","INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        public void updateroom()
        {
            string query = "update room set ROOM_name = '" + rname + "', PAT_id = '" + id + "', PAT_name = '" + name + "', WARD = '" + ward + "', ROOM_status = '" + status + "'where ROOM_id = '" + rid + "' ";
            DAO d = new DAO();
            d.update_room(query);
            MessageBox.Show("room Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
       

        public DataTable displayroom()
        {
            string query = "select * from room";
            DAO d = new DAO();
            d.display_room(query);
            return d.dt;
        }

        public void deleteroom()
        {
            string query = "delete  from room where ROOM_id = '" + rid + "'";
            DAO d = new DAO();
            d.delete_room(query);
            MessageBox.Show("room deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
