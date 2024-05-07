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
    public partial class FRM_BloodTransfusion : Form
    {
        BL.Payment payment = new BL.Payment();
        BL.Blood blood = new BL.Blood();
        BL.Patient patient = new BL.Patient();
        private string Id = "";
        public FRM_BloodTransfusion()
        {
            InitializeComponent();
        }

        public int NumOfProcesses()
        {
            // Get number of transfusion processes
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            int Num = Convert.ToInt32(DAL.ExecuteScalar("SELECT COUNT(*) FROM tblTransfusion WHERE CAST(transfusion_date AS DATE) = CAST(GETDATE() AS DATE);", null));
            lblNumOfProcesses.Text += Num;
            return Num;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dgv_Patient.DataSource = patient.SearchPatientById(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grbTransfusion.Enabled = false;
            txtSearch.Clear();
            this.dgv_Patient.DataSource = patient.SearchPatientById(txtSearch.Text);
        }

        private void FRM_BloodTransfusion_Load(object sender, EventArgs e)
        {
            grbTransfusion.Enabled = false;

            // Show data in DataGridView
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            this.dgv_Transfusion.DataSource = DAL.SelectQuery("SELECT transfusion_id, BagId, Name, transfusion_date FROM tblTransfusion INNER JOIN tblPatient ON tblTransfusion.recipient_id = tblPatient.PatientId WHERE CAST(transfusion_date AS DATE) = CAST(GETDATE() AS DATE);");
            NumOfProcesses();
        }

        private void dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Patient.Rows[e.RowIndex];
            Id = row.Cells["PatientId"].Value.ToString();

            if (dgv_Patient.Columns[e.ColumnIndex].Name == "Transfusion")
            {
                if (MessageBox.Show("هل تريد نقل الدم لهذا المريض؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    grbTransfusion.Enabled = true;
                    grbDonor.Enabled = false;
                    btnTransfusion.Enabled = false;
                }
            }  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            grbDonor.Enabled = true;
            btnTransfusion.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            grbDonor.Enabled = false;
            btnTransfusion.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBagId.Clear();
            txtCivil.Clear();
            rbDonor.Checked = false;
            rbWithoutDonor.Checked = false;
            grbDonor.Enabled = false;
            btnTransfusion.Enabled = false;
        }

        private void btnTransfusion_Click(object sender, EventArgs e)
        {
            if (rbDonor.Checked == true)
            {
                try
                {
                    // Exchange validation
                    if (txtCivil.Text == string.Empty || txtBagId.Text == string.Empty)
                    {
                        MessageBox.Show("قم بإدخال الرقم القومى للمتبرع و رقم الكيس", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (Convert.ToInt32(blood.CheckBlood(Convert.ToInt32(txtBagId.Text), txtCivil.Text)) > 0)
                        {
                            // Transfusion proccess
                            blood.Blood_Transfusion(Convert.ToInt32(Id), rbDonor.Text);
                            MessageBox.Show(blood.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            // show transfusion processes in data grid
                            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                            this.dgv_Transfusion.DataSource = DAL.SelectQuery("SELECT transfusion_id, BagId, Name, transfusion_date FROM tblTransfusion INNER JOIN tblPatient ON tblTransfusion.recipient_id = tblPatient.PatientId WHERE CAST(transfusion_date AS DATE) = CAST(GETDATE() AS DATE);");
                            NumOfProcesses();

                            // Payment proccess
                            payment.PayForTransfusion(blood.transfusionId);
                        }
                        else
                        {
                            MessageBox.Show("لم يتم ادخال كيس الدم من قبل المتبرع", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if(rbWithoutDonor.Checked == true)
            {
                try
                    {
                    blood.Blood_Transfusion(Convert.ToInt32(Id), rbWithoutDonor.Text);
                    MessageBox.Show(blood.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    // show transfusion processes in data grid
                    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                    this.dgv_Transfusion.DataSource = DAL.SelectQuery("SELECT transfusion_id, BagId, Name, transfusion_date FROM tblTransfusion INNER JOIN tblPatient ON tblTransfusion.recipient_id = tblPatient.PatientId WHERE CAST(transfusion_date AS DATE) = CAST(GETDATE() AS DATE);");
                    NumOfProcesses();

                    // Payment proccess
                    payment.PayForTransfusion(blood.transfusionId);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
