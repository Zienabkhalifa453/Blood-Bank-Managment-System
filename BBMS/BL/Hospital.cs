using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BBMS.BL
{
    class Hospital
    {
        DataTable Dt = new DataTable();
        public void AddHospital(string Name, string Address, string City, string PostalCode, string Phone, string Email, string Website)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Address", SqlDbType.VarChar, 100);
            param[1].Value = Address;

            param[2] = new SqlParameter("@City", SqlDbType.VarChar, 50);
            param[2].Value = City;

            param[3] = new SqlParameter("@ZipPostalCode", SqlDbType.VarChar, 10);
            param[3].Value = PostalCode;

            param[4] = new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50);
            param[5].Value = Email;

            param[6] = new SqlParameter("@Website", SqlDbType.VarChar, 50);
            param[6].Value = Website;

            DAL.Open();
            DAL.ExecuteCommand("spInsertHospital", param);
            DAL.Close();
        }

        public DataTable SelectHospital()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            Dt = DAL.SelectData("spSelectHospitals", null);
            DAL.Close();
            return Dt;
        }
        public DataTable SearchHopital(string S)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@String", SqlDbType.VarChar, 50) {Value = S}
            };
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("spSearchHospitl", param);
            return Dt;
        }

        public void UpdateHospital(int Id, string Name, string Address, string City, string PostalCode, string Phone, string Email, string Website)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@HospitalID", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Address", SqlDbType.VarChar, 100);
            param[2].Value = Address;

            param[3] = new SqlParameter("@City", SqlDbType.VarChar, 50);
            param[3].Value = City;

            param[4] = new SqlParameter("@ZipPostalCode", SqlDbType.VarChar, 10);
            param[4].Value = PostalCode;

            param[5] = new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20);
            param[5].Value = Phone;

            param[6] = new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50);
            param[6].Value = Email;

            param[7] = new SqlParameter("@Website", SqlDbType.VarChar, 50);
            param[7].Value = Website;

            DAL.Open();
            DAL.ExecuteCommand("UpdateHospital", param);
            DAL.Close();
        } 

        public void DeleteHospital(int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@HospitalID", SqlDbType.Int);
            param[0].Value = Id;
            DAL.Open();
            DAL.ExecuteCommand("DeleteHospital", param);
            DAL.Close();
        }
    }
}
