using National_ID;
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
    public partial class FRM_ManageDonor : Form
    {
        public string state { get; set; }
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Civil_Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string DonorRegion { get; set; }
        public string BloodGroup { get; set; }
        public string RH { get; set; }
        public DateTime LastDobation { get; set; }

        BL.Donor donor = new BL.Donor();
        public FRM_ManageDonor()
        {
            InitializeComponent();

        }

        public void FillData()
        {
            txtFname.Text = Fname;
            txtMname.Text = Mname;
            txtLname.Text = Lname;
            txtSearch.Text = Civil_Id;
            txtPhone.Text = Phone;
            txtAddress.Text = Address;
            txtRegion.Text = DonorRegion;
            cbBloodType.SelectedItem = BloodGroup;
            cbRh.SelectedItem = RH;
            dtLastDonation.Value = LastDobation.Date;
        }

        public void ClearData()
        {
            txtFname.Clear();
            txtMname.Clear();
            txtLname.Clear();
            txtPhone.Clear();
            txtRegion.Clear();
            txtStatus.Clear();
            txtGender.Clear();
            txtDOB.Clear();
            txtAge.Clear();
            txtCity.Clear();
            txtAddress.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_AddDonor_Load(object sender, EventArgs e)
        {
            if(state == "Add")
            {
                btnAdd.Text = "إضافة";
                btnAdd.Image = Image.FromFile(@"C:\Users\moham\source\repos\BBMS\Images\add_24px.png");
            }
            else
            {
                btnAdd.Text = "تعديل";
                btnAdd.Image = Image.FromFile(@"C:\Users\moham\source\repos\BBMS\Images\pen_24px.png");
            }

            FillData();
        }
        public void InfoBasedOnId(string Id)
        {
            CitizenData citizenData = CitizenDataExtractor.GetCitizenData(Id);
            txtDOB.Text = citizenData.DayOfBirth + "/" + citizenData.MonthOfBirth + "/" + citizenData.YearOfBirth;
            txtCity.Text = citizenData.Governorate;
            txtGender.Text = citizenData.Gender;
            txtAge.Text = citizenData.Age.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(state == "Add")
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
                            btnPrint.Enabled = true;
                            FRM_Donor.getDonorForm.dgv_Donor.DataSource = donor.GetAllDonors();
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
            else
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
                        donor.UpdateDonor(Convert.ToInt32(Id), txtFname.Text, txtMname.Text, txtLname.Text, txtSearch.Text, cbBloodType.Text,
                        cbRh.Text, dtLastDonation.Value.Date, txtPhone.Text, txtAddress.Text, txtRegion.Text);
                        MessageBox.Show("تمت عملية التعديل بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FRM_Donor.getDonorForm.dgv_Donor.DataSource = donor.GetAllDonors();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                FRM_Donor.getDonorForm.dgv_Donor.DataSource = donor.GetAllDonors();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
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
                    Id = Convert.ToInt32(reader["DonorId"]).ToString();
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
                    btnAdd.Enabled = false;
                }
                else
                {
                    btnAdd.Enabled = true;
                }
            }
            else
            {
                this.dtLastDonation.Enabled = true;
                this.btnPrint.Enabled = false;
                state = "Add";
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
            grpDonorData.Enabled = false;
            ClearData();
        }
    }
}
