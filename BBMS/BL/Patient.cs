using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BBMS.BL
{
    class Patient
    {
        DataTable Dt = new DataTable();
        public DataTable SelectPatient()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            Dt = DAL.SelectData("SelectPatientsWithHospital", null);
            DAL.Close();
            return Dt;
        }

        public DataTable SearchPatient(string S)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@String", SqlDbType.VarChar, 50) {Value = S}
            };
            DataTable Dt = new DataTable();
            DAL.Open();
            Dt = DAL.SelectData("spSearchPatient", param);
            DAL.Close();
            return Dt;
        }

        public DataTable SearchPatientById(string Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.VarChar, 20) {Value = Id}
            };
            DataTable Dt = new DataTable();
            DAL.Open();
            Dt = DAL.SelectData("spSearchPatientByCivil", param);
            DAL.Close();
            return Dt;
        }

        public void AddPatient(string PatientName, string Civil_Id, string BloodGroup, string RH, string Phone, string Address, int Hospital_Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = PatientName;

            param[1] = new SqlParameter("@Civil_Id", SqlDbType.VarChar, 20);
            param[1].Value = Civil_Id;

            param[2] = new SqlParameter("@BloodGroup", SqlDbType.Char, 2);
            param[2].Value = BloodGroup;

            param[3] = new SqlParameter("@RhFactor", SqlDbType.Char, 1);
            param[3].Value = RH;

            param[4] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Address", SqlDbType.VarChar, 100);
            param[5].Value = Address;

            param[6] = new SqlParameter("@Hospital_Id", SqlDbType.Int);
            param[6].Value = Hospital_Id;

            DAL.Open();
            DAL.ExecuteCommand("spAddPatient", param);
            DAL.Close();
        }

        public void UpdatePatient(int Id, string PatientName, string Civil_Id, string BloodGroup, string RH, string Phone, string Address, int Hospital_Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@PatientId", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[1].Value = PatientName;

            param[2] = new SqlParameter("@Civil_Id", SqlDbType.VarChar, 20);
            param[2].Value = Civil_Id;

            param[3] = new SqlParameter("@BloodGroup", SqlDbType.Char, 2);
            param[3].Value = BloodGroup;

            param[4] = new SqlParameter("@RhFactor", SqlDbType.Char, 1);
            param[4].Value = RH;

            param[5] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
            param[5].Value = Phone;

            param[6] = new SqlParameter("@Address", SqlDbType.VarChar, 100);
            param[6].Value = Address;

            param[7] = new SqlParameter("@Hospital_Id", SqlDbType.Int);
            param[7].Value = Hospital_Id;

            DAL.Open();
            DAL.ExecuteCommand("spUpdatePatient", param);
            DAL.Close();
        }

        public void DeletePatient(int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@PatientId", SqlDbType.Int);
            param[0].Value = Id;
            DAL.Open();
            DAL.ExecuteCommand("spDeletePatient", param);
            DAL.Close();
        }

        // Check if donor exists
        public object CheckPatient(string Civil_Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            string query = "SELECT COUNT (*) FROM tblPatient WHERE Civil_Id = @Civil_Id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Civil_Id", SqlDbType.VarChar, 14) { Value = Civil_Id }
            };
            DAL.Open();
            object result = DAL.ExecuteScalar(query, param);
            int count = Convert.ToInt32(result);
            DAL.Close();
            return count;
        }
    }
}
