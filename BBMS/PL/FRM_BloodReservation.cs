using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS.PL
{
    public partial class FRM_BloodReservation : Form
    {
        BL.Patient patient = new BL.Patient();
        BL.Blood blood = new BL.Blood();
        public FRM_BloodReservation()
        {
            InitializeComponent();
        }

        public int NumOfProcesses()
        {
            // Get number of transfusion processes
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            int Num = Convert.ToInt32(DAL.ExecuteScalar("SELECT COUNT(*) FROM tblReservations WHERE CAST(ReservationDate AS DATE) = CAST(GETDATE() AS DATE);", null));
            lblNumOfProcesses.Text += Num;
            return Num;
        }

        private void FRM_BloodReservation_Load(object sender, EventArgs e)
        {
            // Show data in DataGridView
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            this.dgv_Reservation.DataSource = DAL.SelectQuery("SELECT ReservationID, BloodBagID, Name, ReservationDate, ReservedBy FROM tblReservations INNER JOIN tblPatient ON tblReservations.PatientID = tblPatient.PatientId WHERE CAST(ReservationDate AS DATE) = CAST(GETDATE() AS DATE);");
            
            NumOfProcesses();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dgv_Patient.DataSource = patient.SearchPatientById(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            this.dgv_Patient.DataSource = patient.SearchPatientById(txtSearch.Text);
        }

        private void dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Patient.Rows[e.RowIndex];
            int Patient_Id = Convert.ToInt32(row.Cells["PatientId"].Value.ToString());

            if (dgv_Patient.Columns[e.ColumnIndex].Name == "Reserve")
            {
                if (MessageBox.Show("هل تريد حجز كيس دم لهذا المريض؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DateTime date = DateTime.Now;
                        blood.Blood_Reservation(Patient_Id, date.Date, "m");

                        if(blood.Message == null)
                        {
                            MessageBox.Show("تم الحجز بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show(blood.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        // Show data in DataGridView
                        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                        this.dgv_Reservation.DataSource = DAL.SelectQuery("SELECT ReservationID, BloodBagID, Name, ReservationDate, ReservedBy FROM tblReservations INNER JOIN tblPatient ON tblReservations.PatientID = tblPatient.PatientId WHERE CAST(ReservationDate AS DATE) = CAST(GETDATE() AS DATE);");

                        // Update number of processes
                        NumOfProcesses();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
