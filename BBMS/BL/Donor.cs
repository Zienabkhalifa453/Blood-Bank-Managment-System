using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.BL
{
    class Donor
    {
        public string Message { get; set; }
        public void AddDonor(string FName, string MName, string LName, string Civil_Id,
                             string bloodGroup, string RhFactor, DateTime LastDonation, string Phone,
                             string Address, string Region)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@FName", SqlDbType.VarChar, 10);
            param[0].Value = FName;

            param[1] = new SqlParameter("@MName", SqlDbType.VarChar, 10);
            param[1].Value = MName;

            param[2] = new SqlParameter("@LName", SqlDbType.VarChar, 10);
            param[2].Value = LName;

            param[3] = new SqlParameter("@Civil_Id", SqlDbType.VarChar, 14);
            param[3].Value = Civil_Id;

            param[4] = new SqlParameter("@BloodGroup", SqlDbType.Char, 2);
            param[4].Value = bloodGroup;

            param[5] = new SqlParameter("@RhFactor", SqlDbType.Char, 1);
            param[5].Value = RhFactor;

            param[6] = new SqlParameter("@LastDonation", SqlDbType.Date);
            param[6].Value = LastDonation.Date;

            param[7] = new SqlParameter("@Phone", SqlDbType.VarChar, 12);
            param[7].Value = Phone;

            param[8] = new SqlParameter("@Address", SqlDbType.VarChar, 200);
            param[8].Value = Address;

            param[9] = new SqlParameter("@Region", SqlDbType.VarChar, 20);
            param[9].Value = Region;

            param[10] = new SqlParameter("@Message", SqlDbType.VarChar, 100);
            param[10].Direction = System.Data.ParameterDirection.Output;

            DAL.ExecuteCommand("SpAddDonor", param);
            Message = param[10].Value.ToString();
           
            DAL.Close();
        }
        public DataTable GetAllDonors()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("spGetAllDonors", null);
            DAL.Close();
            return Dt;
        }

        // Check if donor exists
        public object CheckDonor(string Civil_Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            string query = "SELECT COUNT (*) FROM tblDonor WHERE Civil_Id = @Civil_Id";
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

        public void UpdateDonor(int Id, string FName, string MName, string LName, string Civil_Id,
                             string bloodGroup, string RhFactor, DateTime LastDonation, string Phone,
                             string Address, string Region)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            param[1] = new SqlParameter("@FName", SqlDbType.VarChar, 10);
            param[1].Value = FName;

            param[2] = new SqlParameter("@MName", SqlDbType.VarChar, 10);
            param[2].Value = MName;

            param[3] = new SqlParameter("@LName", SqlDbType.VarChar, 10);
            param[3].Value = LName;

            param[4] = new SqlParameter("@Civil_Id", SqlDbType.VarChar, 14);
            param[4].Value = Civil_Id;

            param[5] = new SqlParameter("@BloodGroup", SqlDbType.Char, 2);
            param[5].Value = bloodGroup;

            param[6] = new SqlParameter("@RhFactor", SqlDbType.Char, 1);
            param[6].Value = RhFactor;

            param[7] = new SqlParameter("@LastDonation", SqlDbType.Date);
            param[7].Value = LastDonation.Date;

            param[8] = new SqlParameter("@Phone", SqlDbType.VarChar, 12);
            param[8].Value = Phone;

            param[9] = new SqlParameter("@Address", SqlDbType.VarChar, 200);
            param[9].Value = Address;

            param[10] = new SqlParameter("@Region", SqlDbType.VarChar, 20);
            param[10].Value = Region;

            DAL.Open();
            DAL.ExecuteCommand("SpUpdateDonor", param);
            DAL.Close();
        }
        public DataTable SeachDonor(string S)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@String", SqlDbType.VarChar, 50) {Value = S}
            };

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("spSearchDonors", param);
            DAL.Close();
            return Dt;
        }
        public void DeleteDonor(int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int) {Value = Id }
            };
            DAL.Open();
            DAL.ExecuteCommand("spDeleteDonor", param);
            DAL.Close();
        }
    }
}

