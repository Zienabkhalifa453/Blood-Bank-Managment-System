using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using National_ID;
namespace BBMS.PL
{
    public partial class FRM_ManageHospital : Form
    {
        BL.Hospital hospital = new BL.Hospital();
        public bool ShowAddButton { get; set; }
        public bool ShowUpdateButton { get; set; }
        public Point location { set; get; }

        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public FRM_ManageHospital()
        {
            InitializeComponent();
            this.cbGov.DataSource = Enum.GetNames(typeof(Governorates));
        }

        public void FillData()
        {
            txtName.Text = HospitalName;
            txtAddress.Text = Address;
            cbGov.SelectedItem = City;
            txtPostalCode.Text = PostalCode;
            txtPhone.Text = Phone;
            txtEmail.Text = Email;
            txtWebsite.Text = Website;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ClearData()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();
            txtPostalCode.Clear();
            cbGov.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void FRM_ManageHospital_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = ShowAddButton;
            btnupdate.Visible = ShowUpdateButton;
            btnCancel.Location = location;

            FillData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == string.Empty || txtPhone.Text == string.Empty || txtEmail.Text == string.Empty || cbGov.SelectedIndex == -1)
            {
                MessageBox.Show("قم بملئ البيانات اولا", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    hospital.AddHospital(txtName.Text, txtAddress.Text, cbGov.SelectedItem.ToString(), txtPostalCode.Text, txtPhone.Text,
                               txtEmail.Text, txtWebsite.Text);
                    MessageBox.Show("تمت الإضافة بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FRM_Hospital.getHospitalForm.dgv_Hospital.DataSource = hospital.SelectHospital();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPhone.Text == string.Empty || txtEmail.Text == string.Empty || cbGov.SelectedIndex == -1)
            {
                MessageBox.Show("قم بملئ البيانات اولا", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    hospital.UpdateHospital(Id, txtName.Text, txtAddress.Text, cbGov.SelectedItem.ToString(), txtPostalCode.Text, txtPhone.Text,
                               txtEmail.Text, txtWebsite.Text);
                    MessageBox.Show("تم التعديل بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FRM_Hospital.getHospitalForm.dgv_Hospital.DataSource = hospital.SelectHospital();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
