using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public void sp_InsertDoctor(string _dname, string _dage, string _dgender, string _dphone, string _dpassword, string _daddress, string _demail)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_InsertDoctor", _dname, _dage, _dgender, _dphone, _dpassword, _daddress, _demail);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void UpdateDoctor(string _Doc_id,string _dname, string _dage, string _dgender, string _dphone, string _dpassword, string _daddress, string _demail)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_UpdateDoctor",_Doc_id, _dname, _dage, _dgender, _dphone, _dpassword, _daddress, _demail);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
    }
}
