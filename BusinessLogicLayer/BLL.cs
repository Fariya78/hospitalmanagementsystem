using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        public void deleteDoctor(string _Doc_id )
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_DeleteDoctor", _Doc_id);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void Insertdiagnosis(string _Diog_id, string _dname, string _dsymp, string _diognosis, string _dmedic, string _droom, string _dpayment)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_Insertdiagnosis", _Diog_id, _dname, _dname, _dsymp, _diognosis, _dmedic, _droom, _dpayment);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void updatediagnosis(string _Doc_no,string _Diog_id, string _dname, string _dsymp, string _diognosis, string _dmedic, string _droom, string _dpayment)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_UpdateDiagnosis", _Diog_id, _dname, _dname, _dsymp, _diognosis, _dmedic, _droom, _dpayment);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void deletediagnosis(string _Doc_id)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_DeleteDiagnosis", _Doc_id);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void Insertpatient(string _pname, string _ppage, string _gender, string _address, string _phone, string _group)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_InsertPateint", _pname, _ppage, _gender, _address, _phone, _group);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void patientupdate(string _p_id, string _pname, string _ppage, string _gender, string _address, string _phone, string _group)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_Updatepatient", _p_id, _pname, _ppage, _gender, _address, _phone, _group);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
        public void patientdelete(string _p_id)
        {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("sp_Deletepatient", _p_id);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }

    }
}
