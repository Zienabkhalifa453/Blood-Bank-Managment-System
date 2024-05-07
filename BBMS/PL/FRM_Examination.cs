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
    public partial class FRM_Examination : Form
    {
        BL.Examination examination = new BL.Examination();

        private int Donor_Id;
        private string Civil_Id;
        public FRM_Examination()
        {
            InitializeComponent();
        }
        public FRM_Examination(int Id, string civil_Id)
        {
            InitializeComponent();
            this.Donor_Id = Id;
            this.Civil_Id = civil_Id;
        }

        private void FRM_Examination_Load(object sender, EventArgs e)
        {
            txtCivil_Id.Text = Civil_Id;
            txtDonor_Id.Text = Donor_Id.ToString();

            if (txtCivil_Id.Text == string.Empty || txtDonor_Id.Text == string.Empty)
            {
                grpExamination.Enabled = false;
                grpButtons.Enabled = false;
            }
            else
            {
                grpExamination.Enabled = true;
                grpButtons.Enabled = true;
            }

            if (txtStatus.Text == string.Empty)
                btnAddBlood.Enabled = false;
            else
                btnAddBlood.Enabled = true;
        }

        public void ClearDate()
        {
            txtHigh_Pressure.Clear();
            txtLow_Pressure.Clear();
            txtHomoglobin.Clear();
            txtPulse_Rate.Clear();
            txtTemp.Clear();
            txtStatus.Clear();
            txtNotes.Clear();
            txtWeight.Clear();
            cbPulse.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLow_Pressure.Text == string.Empty || txtHigh_Pressure.Text == string.Empty
                || txtPulse_Rate.Text == string.Empty || cbPulse.Text == string.Empty || txtHomoglobin.Text == string.Empty
                || txtWeight.Text == string.Empty || txtTemp.Text == string.Empty)
            {
                MessageBox.Show("قم بملئ البيانات أولا", "عملية الفحص", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    examination.AddExamination(Donor_Id, dateTimePicker1.Value.Date, Convert.ToInt32(txtLow_Pressure.Text),
                                               Convert.ToInt32(txtHigh_Pressure.Text), cbPulse.Text,
                                                Convert.ToInt32(txtPulse_Rate.Text), Convert.ToInt32(txtHomoglobin.Text),
                                                Convert.ToInt32(txtWeight.Text), Convert.ToInt32(txtTemp.Text), txtTemp.Text,
                                                examination.Exam_Status, examination.Message);
                    txtStatus.Text = examination.Exam_Status;
                    MessageBox.Show(examination.Message, "عملية الفحص", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Donation ban
                    if (examination.Exam_Status == "لا-غير مقبول")
                    {
                        btnAddBlood.Enabled = false;
                    }
                    else
                    {
                        btnAddBlood.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearDate();
        }

        private void btnAddBlood_Click(object sender, EventArgs e)
        {
            FRM_AddBlood frmBlood = new FRM_AddBlood(Donor_Id);
            frmBlood.TopLevel = false;
            frmBlood.FormBorderStyle = FormBorderStyle.None;
            frmBlood.Dock = DockStyle.Fill;

            Control parentControl = this.Parent;
            while (parentControl.GetType() != typeof(MainPage))
            {
                parentControl = parentControl.Parent;
            }

            MainPage parentForm = (MainPage)parentControl;
            parentForm.ParentPanel.Controls.Clear();
            parentForm.ParentPanel.Controls.Add(frmBlood);
            frmBlood.Show();
        }
    }
}
