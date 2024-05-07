using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using National_ID;

namespace BBMS.PL
{
    public partial class FRM_Donate : Form
    {
        BL.Donor donor = new BL.Donor();
        private int Donor_Id;
        private string Civil_Id;
        public string state = "";
        private static FRM_Donate frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Donate getDonateForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Donate();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_Donate()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.grpDonorData.Enabled = false;
            this.grpButtons.Enabled = false;
        }

        public void InfoBasedOnId(string Id)
        {
            CitizenData citizenData = CitizenDataExtractor.GetCitizenData(Id);
            txtDOB.Text = citizenData.DayOfBirth + "/" + citizenData.MonthOfBirth + "/" + citizenData.YearOfBirth;
            txtCity.Text = citizenData.Governorate;
            txtGender.Text = citizenData.Gender;
            txtAge.Text = citizenData.Age.ToString();

        }

        public void ClearData()
        {
            txtFname.Clear();
            txtMname.Clear();
            txtLname.Clear();
            dtLastDonation.Value = DateTime.Today;
            txtPhone.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
            txtRegion.Clear();
            txtDOB.Clear();
            txtCity.Clear();
            txtGender.Clear();
            txtAge.Clear();
            cbBloodType.SelectedIndex = -1;
            cbRh.SelectedIndex = -1;
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            FRM_Examination frmExamination = new FRM_Examination(Donor_Id, Civil_Id);
            frmExamination.TopLevel = false;
            frmExamination.FormBorderStyle = FormBorderStyle.None;
            frmExamination.Dock = DockStyle.Fill;

            Control parentControl = this.Parent;
            while (parentControl.GetType() != typeof(MainPage))
            {
                parentControl = parentControl.Parent;
            }

            MainPage parentForm = (MainPage)parentControl;
            parentForm.ParentPanel.Controls.Clear();
            parentForm.ParentPanel.Controls.Add(frmExamination);
            frmExamination.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCancelSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            this.grpDonorData.Enabled = false;
            this.grpButtons.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(state == "add")
            {
                if (txtFname.Text == string.Empty || txtMname.Text == string.Empty || txtLname.Text == string.Empty
                || txtSearch.Text == string.Empty || txtPhone.Text == string.Empty || txtRegion.Text == string.Empty)
                {
                    MessageBox.Show("قم بإدخال البيانات المفقودة.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        donor.AddDonor(txtFname.Text, txtMname.Text, txtLname.Text, txtSearch.Text, cbBloodType.Text,
                        cbRh.Text, dtLastDonation.Value.Date, txtPhone.Text, txtAddress.Text, txtRegion.Text);
                        if (donor.Message == "تمت عملية الإضافة بنجاح.")
                        {
                            MessageBox.Show(donor.Message, "’Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnExamination.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show(donor.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(state == "update")
            {
                this.dtLastDonation.Enabled = false;
                if (txtFname.Text == string.Empty || txtMname.Text == string.Empty || txtLname.Text == string.Empty
                || txtSearch.Text == string.Empty || txtPhone.Text == string.Empty || txtRegion.Text == string.Empty)
                {
                    MessageBox.Show("قم بإدخال البيانات المفقودة.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        // Update Code here
                        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                        DAL.Open();
                        donor.UpdateDonor(Donor_Id, txtFname.Text, txtMname.Text, txtLname.Text, txtSearch.Text, cbBloodType.Text,
                                cbRh.Text, dtLastDonation.Value.Date, txtPhone.Text, txtAddress.Text, txtRegion.Text);
                        MessageBox.Show("تم التعديل بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Stata variable doesn't initialized..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.grpDonorData.Enabled = true;
            this.grpButtons.Enabled = true;
            if (Convert.ToInt32(donor.CheckDonor(txtSearch.Text)) > 0)
            {
                this.dtLastDonation.Enabled = false;
                state = "update";
                btnAdd.Text = "تعديل";
                btnAdd.Image = Image.FromFile(@"C:\Users\moham\source\repos\BBMS\Images\pen_24px.png");
                Civil_Id = txtSearch.Text;
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

                // Open the database connection
                DAL.Open();

                string query = "SELECT DonorId, FName, MName, LName, LastDonation, Phone, Donor_Address, Region, BloodGroup, RhFactor, Donor_Status FROM tblDonor WHERE Civil_Id = @Civil_Id";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@Civil_Id", SqlDbType.VarChar, 14) {Value = txtSearch.Text}
                };

                // Execute the query and get a SqlDataReader object
                SqlDataReader reader = DAL.ExecuteReader(query, param);

                while (reader.Read())
                {
                    Donor_Id = Convert.ToInt32(reader["DonorId"]);
                    txtFname.Text = reader["FName"].ToString();
                    txtMname.Text = reader["MName"].ToString();
                    txtLname.Text = reader["LName"].ToString();
                    dtLastDonation.Value = Convert.ToDateTime(reader["LastDonation"]).Date;
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Donor_Address"].ToString();
                    txtRegion.Text = reader["Region"].ToString();
                    cbBloodType.Text = reader["BloodGroup"].ToString();
                    cbRh.Text = reader["RhFactor"].ToString();
                    txtStatus.Text = reader["Donor_Status"].ToString();
                }

                // Close the SqlDataReader and database connection
                reader.Close();
                DAL.Close();

                // Enable or Unenable Examination depending on the difference between today's date and last donation date.
                TimeSpan difference = DateTime.Today - dtLastDonation.Value;
                int daysDifference = difference.Days;
                if (daysDifference < 90)
                {
                    btnExamination.Enabled = false;
                }
                else
                {
                    btnExamination.Enabled = true;
                }
            }
            else
            {
                this.dtLastDonation.Enabled = true;
                this.btnExamination.Enabled = false;
                this.btnPrint.Enabled = false;
                state = "add";
                btnAdd.Text = "إضافة";
                btnAdd.Image = Image.FromFile(@"C:\Users\moham\source\repos\BBMS\Images\add_24px.png");
                ClearData();
                txtFname.Focus();
            }

            // Get City, age, Gender and birthdate of donor based on his/her national id.
            InfoBasedOnId(txtSearch.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearData();
            this.grpDonorData.Enabled = false;
            this.grpButtons.Enabled = false;
        }
    }
}

