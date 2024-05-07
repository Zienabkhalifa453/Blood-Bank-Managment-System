using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BBMS.BL
{
    class Payment
    {
        public void PayForTransfusion(int transfusionId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@TransfusionId", SqlDbType.Int) {Value = transfusionId}
            };

            DAL.Open();
            DAL.ExecuteCommand("spPayForTransfusion", param);
            DAL.Close();
        }
    }
}
