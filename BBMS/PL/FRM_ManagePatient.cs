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
    public partial class FRM_ManagePatient : Form
    {
        BL.Hospital hospital = new BL.Hospital();
        BL.Patient patient = new BL.Patient();
        private int Patient_Id;

        public string state = "add";
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Civil_Id { get; set; }
        public string BloodGroup { get; set; }
        public string RH { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Hospital { get; set; }

        public FRM_ManagePatient()
        {
            InitializeComponent();
            this.cbHospital.DataSource = hospital.SelectHospital();
            this.cbHospital.DisplayMember = "HospitalName";
            this.cbHospital.ValueMember = "HospitalID";
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
            txtName.Clear();
            txtCivil_Id.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cbBloodGroup.SelectedIndex = -1;
            cbRh.SelectedIndex = -1;
            cbHospital.SelectedIndex = -1;
        }
        public void FillData()
        {
            txtName.Text = PatientName;
            txtCivil_Id.Text = Civil_Id;
            txtAddress.Text = Address;
            txtPhone.Text = Phone;
            cbBloodGroup.SelectedItem = BloodGroup;
            cbRh.SelectedItem = RH;
            cbHospital.SelectedItem = Hospital;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FRM_ManagePatient_Load(object sender, EventArgs e)
        {
            if (state == "add")
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
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.grpPatientData.Enabled = true;
            this.grpButtons.Enabled = true;

            if (Convert.ToInt32(patient.CheckPatient(txtCivil_Id.Text)) > 0)
            {
                btnAdd.Enabled = false;
                Civil_Id = txtCivil_Id.Text;

                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

                // Open the database connection
                DAL.Open();

                string query = "SELECT PatientId, Name, Phone, tblPatient.Address, BloodGroup, RhFactor, HospitalName FROM tblPatient Left JOIN tblHospital  ON tblPatient.Hospital_Id = tblHospital.HospitalID WHERE Civil_Id = @Civil_Id;";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@Civil_Id", SqlDbType.VarChar, 14) {Value = txtCivil_Id.Text}
                };

                // Execute the query and get a SqlDataReader object
                SqlDataReader reader = DAL.ExecuteReader(query, param);

                while (reader.Read())
                {
                    Patient_Id = Convert.ToInt32(reader["PatientId"]);
                    txtName.Text = reader["Name"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    cbBloodGroup.Text = reader["BloodGroup"].ToString();
                    cbRh.Text = reader["RhFactor"].ToString();
                    cbHospital.Text = reader["HospitalName"].ToString();
                }

                // Close the SqlDataReader and database connection
                reader.Close();
                DAL.Close();
            }
            else
            {
                btnAdd.Enabled = true;
                ClearData();
                txtName.Focus();

            }

            // Get City, age, Gender and birthdate of donor based on his/her national id.
            //InfoBasedOnId(txtCivil_Id.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
            this.grpButtons.Enabled = false;
            this.grpPatientData.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (txtName.Text == string.Empty || txtCivil_Id.Text == string.Empty || txtPhone.Text == string.Empty)
                {
                    MessageBox.Show("قم بملئ البيانات المفقودة!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        patient.AddPatient(txtName.Text, txtCivil_Id.Text, cbBloodGroup.Text, cbRh.Text,
                        txtPhone.Text, txtAddress.Text, Convert.ToInt32(cbHospital.SelectedValue));
                        MessageBox.Show("تمت الإضافة بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        FRM_Patient.getPatientForm.dgv_Patient.DataSource = patient.SelectPatient();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtName.Text == string.Empty || txtCivil_Id.Text == string.Empty || txtPhone.Text == string.Empty)
                {
                    MessageBox.Show("قم بملئ البيانات المفقودة!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        patient.UpdatePatient(Id, txtName.Text, txtCivil_Id.Text, cbBloodGroup.SelectedItem.ToString(), cbRh.SelectedItem.ToString(),
                        txtPhone.Text, txtAddress.Text, Convert.ToInt32(cbHospital.SelectedValue));
                        MessageBox.Show("تم التعديل  بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        FRM_Patient.getPatientForm.dgv_Patient.DataSource = patient.SelectPatient();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
