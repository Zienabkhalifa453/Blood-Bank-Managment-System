using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.BL
{
    class Examination
    {
        public string Exam_Status { get; set; }
        public string Message { get; set; }
        public void AddExamination(int DonorId, DateTime Date, int Low_Pressure, int High_Pressure, string pluse,
                                    int Pluse_Rate, int Homoglobin, int Weight, decimal Temp, string notes, string Status,
                                    string msg)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@Donor_Id", SqlDbType.Int);
            param[0].Value = DonorId;

            param[1] = new SqlParameter("@Date", SqlDbType.Date);
            param[1].Value = Date.Date;

            param[2] = new SqlParameter("@Low_Pressure", SqlDbType.Int);
            param[2].Value = Low_Pressure;

            param[3] = new SqlParameter("@High_Pressure", SqlDbType.Int);
            param[3].Value = High_Pressure;

            param[4] = new SqlParameter("@Pluse", SqlDbType.VarChar, 10);
            param[4].Value = pluse;

            param[5] = new SqlParameter("@Pluse_Rate", SqlDbType.Int);
            param[5].Value = Pluse_Rate;

            param[6] = new SqlParameter("@Homoglobin", SqlDbType.Int);
            param[6].Value = Homoglobin;

            param[7] = new SqlParameter("@Weight", SqlDbType.Int);
            param[7].Value = Weight;

            param[8] = new SqlParameter("@Temperature", SqlDbType.Decimal);
            param[8].Value = Temp;

            param[9] = new SqlParameter("@Notes", SqlDbType.VarChar, 200);
            param[9].Value = notes;

            param[10] = new SqlParameter("@Exam_Status", SqlDbType.VarChar, 50);
            param[10].Direction = ParameterDirection.Output;

            param[11] = new SqlParameter("@Message", SqlDbType.VarChar, 100);
            param[11].Direction = ParameterDirection.Output;

            DAL.ExecuteCommand("spAddExamination", param);

            Status = param[10].Value.ToString();
            msg = param[11].Value.ToString();
            Exam_Status = Status;
            Message = msg;

            DAL.Close();
        }
    }
}
