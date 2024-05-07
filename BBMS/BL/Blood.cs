using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BBMS.BL
{
    class Blood
    {
        public string Message;
        public int transfusionId;
        public void AddBlood(int Donor_Id, DateTime Collection, DateTime Expiration, decimal volume,
                            decimal price, string StorageLocation, string Source)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@DonorID", SqlDbType.Int);
            param[0].Value = Donor_Id;

            param[1] = new SqlParameter("@CollectionDate", SqlDbType.Date);
            param[1].Value = Collection.Date;

            param[2] = new SqlParameter("@ExpirationDate", SqlDbType.Date);
            param[2].Value = Expiration.Date;

            param[3] = new SqlParameter("@Volume", SqlDbType.Decimal);
            param[3].Value = volume;

            param[4] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[4].Value = price;

            param[5] = new SqlParameter("@StorageLocation", SqlDbType.VarChar, 50);
            param[5].Value = StorageLocation;

            param[6] = new SqlParameter("@Donation_Source", SqlDbType.VarChar, 50);
            param[6].Value = Source;

            DAL.Open();
            DAL.ExecuteCommand("spInsertBloodBag", param);
            DAL.Close();
        }

        public DataTable SelectBlood(string query)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text; 
            sqlcmd.CommandText = query;
            sqlcmd.Connection = DAL.sqlConnection;

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void TestBlood(int BagId, string Type, string Rh, string Status, string Note)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@BagId", SqlDbType.Int);
            param[0].Value = BagId;

            param[1] = new SqlParameter("@BloodType", SqlDbType.Char, 2);
            param[1].Value = Type;

            param[2] = new SqlParameter("@Rh", SqlDbType.Char, 1);
            param[2].Value = Rh;

            param[3] = new SqlParameter("@Status", SqlDbType.VarChar, 50);
            param[3].Value = Status;

            param[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
            param[4].Value = Note;

            DAL.Open();
            DAL.ExecuteCommand("spTestBlood", param);
            DAL.Close();
        }

        public void Blood_Transfusion(int PatientId, string status)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
            param[0].Value = PatientId;

            param[1] = new SqlParameter("@Status", SqlDbType.VarChar, 50);
            param[1].Value = status;

            param[2] = new SqlParameter("@TransfusionId", SqlDbType.Int);
            param[2].Direction = ParameterDirection.Output;

            param[3] = new SqlParameter("@Message", SqlDbType.VarChar, 100);
            param[3].Direction = ParameterDirection.Output;

            DAL.Open();
            DAL.ExecuteCommand("PerformTransfusion", param);
            Message = param[3].Value.ToString();
            transfusionId = Convert.ToInt32(param[2].Value);
            DAL.Close();
        }

        public void Blood_Reservation(int PatientId, DateTime ReservationDate, string ReservedBy)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
            param[0].Value = PatientId;

            param[1] = new SqlParameter("@ReservationDate", SqlDbType.Date);
            param[1].Value = ReservationDate;

            param[2] = new SqlParameter("@ReservedBy", SqlDbType.VarChar, 50);
            param[2].Value = ReservedBy;

            try
            {
                // Open the connection and execute the command
                DAL.Open();
                DAL.ExecuteCommand("spInsertReservation", param);
            }
            catch (SqlException ex)
            {
                // Error message from SQL
                Message = ex.Message;
            }
            finally
            {
                // Close the connection
                DAL.Close();
            }
        }

        // Check if Bag exists
        public object CheckBlood(int bagId, string Civil_Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            string query = "SELECT COUNT (*) FROM tblBloodBags INNER JOIN tblDonor ON tblBloodBags.DonorID = tblDonor.DonorId WHERE BagID = @bagId AND Civil_Id = @Civil_Id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@bagId", SqlDbType.Int) {Value = bagId},
                new SqlParameter("@Civil_Id", SqlDbType.VarChar, 14) { Value = Civil_Id }
                
            };
            DAL.Open();
            object result = DAL.ExecuteScalar(query, param);
            DAL.Close();
            return result;
        }

        public void DeleteReservation(int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int) {Value = Id}
            };
            DAL.Open();
            DAL.ExecuteCommand("spDeleteReservation", param);
            DAL.Close();
        }

        public void ReservationDelivery(int ReservationId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ReservationId", SqlDbType.Int);
            param[0].Value = ReservationId;

            param[1] = new SqlParameter("@TransfusionId", SqlDbType.Int);
            param[1].Direction = ParameterDirection.Output;

            DAL.Open();
            DAL.ExecuteCommand("spReservationDelivery", param);
            DAL.Close();
        }

        public DataTable SearchReservation(string s)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@String", SqlDbType.VarChar, 50) {Value = s}
            };

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("spSearchReservation", param);
            DAL.Close();
            return Dt;
        }
    }
}
