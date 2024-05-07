using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.DAL
{
    class DataAccessLayer
    {
        public SqlConnection sqlConnection;

        //This constructor initialize the connection object
        public DataAccessLayer()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-5TIJT66\\SQLEXPRESS; Database=BBMS_DB; Integrated Security=true");
        }

        // Method to open connection
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        // Method to close the connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // Method to read data from database
        public DataTable SelectData(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Procedure;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Method to Insert, Update and Delete data from database
        public void ExecuteCommand(string Stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_Procedure;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }

        // Method to execute a SQL query and retrieve a SqlDataReader object
        public SqlDataReader ExecuteReader(string query, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text; // Use CommandType.Text for SQL queries
            sqlcmd.CommandText = query;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }

        // Method to execute a SQL query and return a scalar value
        public object ExecuteScalar(string query, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text; 
            sqlcmd.CommandText = query;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            object result = sqlcmd.ExecuteScalar();
            return result;
        }

        public DataTable SelectQuery(string query)
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
    }
}
