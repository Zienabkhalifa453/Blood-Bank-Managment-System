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
    public partial class FRM_BloodTestResult : Form
    {
        BL.Blood blood = new BL.Blood();
        private int UntestedBags;

        private static FRM_BloodTestResult frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_BloodTestResult getTestForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_BloodTestResult();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public FRM_BloodTestResult()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dgv_Blood.DataSource = blood.SelectBlood("SELECT BagID, (BloodType + ' ' + RhFactor) AS BloodType, CollectionDate, ExpirationDate, Volume, Price, DonorID, StorageLocation, Donation_Source, Status FROM tblBloodBags WHERE Status = 'غير مختبر';");
            
        }

        public void ClearData()
        {
            txtBagId.Clear();
            txtNotes.Clear();
            cbStatus.SelectedIndex = -1;
            cbBloodType.SelectedIndex = -1;
            cbRh.SelectedIndex = -1;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void FRM_BloodTestResult_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            UntestedBags = Convert.ToInt32(DAL.ExecuteScalar("SELECT COUNT(*) FROM tblBloodBags WHERE Status = 'غير مختبر';", null));

            lblTotalRows.Text += UntestedBags;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBagId.Text == string.Empty || cbBloodType.SelectedIndex == -1 || cbRh.SelectedIndex == -1
                || cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("رجاءا قم بملئ البيانات المطلوبة أولا", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    blood.TestBlood(Convert.ToInt32(txtBagId.Text), cbBloodType.SelectedItem.ToString(), cbRh.SelectedItem.ToString(), cbStatus.SelectedItem.ToString(), txtNotes.Text);
                    MessageBox.Show("تم التسجيل بنجاح", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_BloodTestResult.getTestForm.dgv_Blood.DataSource = blood.SelectBlood("SELECT BagID, (BloodType + ' ' + RhFactor) AS BloodType, CollectionDate, ExpirationDate, Volume, Price, DonorID, StorageLocation, Donation_Source, Status FROM tblBloodBags WHERE Status = 'غير مختبر';");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void dgv_Blood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Blood.Rows[e.RowIndex];
            if (dgv_Blood.Columns[e.ColumnIndex].Name == "Test")
            {
                txtBagId.Text = row.Cells["Column1"].Value.ToString();
            }
        }
    }
}
