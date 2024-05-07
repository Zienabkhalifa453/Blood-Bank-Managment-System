using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS.PL
{
    public partial class FRM_ManageReservation : Form
    {
        BL.Blood blood = new BL.Blood();
        private string Id = "";
        public FRM_ManageReservation()
        {
            InitializeComponent();
        }
        public int NumOfProcesses()
        {
            // Get number of transfusion processes
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            int Num = Convert.ToInt32(DAL.ExecuteScalar("SELECT COUNT(*) FROM tblReservations WHERE Status = 'قيد الانتظار';", null));
            lblNumOfProcesses.Text += Num;
            return Num;
        }

        private void FRM_ManageReservation_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            this.dgv_Reservation.DataSource = DAL.SelectQuery("SELECT ReservationID, BloodBagID, Name, ReservationDate, ReservedBy FROM tblReservations INNER JOIN tblPatient ON tblReservations.PatientID = tblPatient.PatientId WHERE Status = 'قيد الانتظار';");
            NumOfProcesses();
        }

        private void dgv_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Reservation.Rows[e.RowIndex];
            Id = row.Cells["Column1"].Value.ToString();

            if (dgv_Reservation.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("هل تريد حذف هذا الحجز؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        blood.DeleteReservation(Convert.ToInt32(Id));
                        MessageBox.Show("تم الغاء الحجز", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                        this.dgv_Reservation.DataSource = DAL.SelectQuery("SELECT ReservationID, BloodBagID, Name, ReservationDate, ReservedBy FROM tblReservations INNER JOIN tblPatient ON tblReservations.PatientID = tblPatient.PatientId WHERE Status = 'قيد الانتظار';");
                        NumOfProcesses();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else if(dgv_Reservation.Columns[e.ColumnIndex].Name == "delivery")
            {
                if (MessageBox.Show("هل تريد صرف الدم المحجوز؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        blood.ReservationDelivery(Convert.ToInt32(Id));
                        MessageBox.Show("تم صرف الدم المحجوز", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                        this.dgv_Reservation.DataSource = DAL.SelectQuery("SELECT ReservationID, BloodBagID, Name, ReservationDate, ReservedBy FROM tblReservations INNER JOIN tblPatient ON tblReservations.PatientID = tblPatient.PatientId WHERE Status = 'قيد الانتظار';");
                        NumOfProcesses();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgv_Reservation.DataSource = blood.SearchReservation(txtSearch.Text);
        }
    }
}
