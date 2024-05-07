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
    public partial class FRM_AddBlood : Form
    {
        BL.Blood blood = new BL.Blood();

        private int Donor_Id;
        public FRM_AddBlood()
        {
            InitializeComponent();
        }
        public FRM_AddBlood(int Id)
        {
            InitializeComponent();
            this.Donor_Id = Id;
        }

        private void FRM_AddBlood_Load(object sender, EventArgs e)
        {
            txtDonorId.Text = Donor_Id.ToString();

            if (txtDonorId.Text == string.Empty)
            {
                grpBloodInfo.Enabled = false;
                grpButtons.Enabled = false;
            }
            else
            {
                grpBloodInfo.Enabled = true;
                grpButtons.Enabled = true;
            }

            // The expiration date will be set automatically based on settings.
            // Mostly 3 months
            dtCollection.Value = DateTime.Today;
            this.dtCollection.Enabled = false;
            dtExpiration.Value = dtCollection.Value.AddMonths(3);
            this.dtExpiration.Enabled = false;
        }

        public void ClearData()
        {
            cbSource.SelectedIndex = -1;
            dtCollection.Value = DateTime.Today;
            dtExpiration.Value = dtCollection.Value.AddMonths(3);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVolume.Text == string.Empty || txtPrice.Text == string.Empty || txtStorageLocation.Text == string.Empty
                || cbSource.SelectedIndex == -1 || dtCollection.Value.Date != DateTime.Today)
            {
                MessageBox.Show("قم بملئ البيانات أولا", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    blood.AddBlood(Donor_Id, dtCollection.Value.Date, dtExpiration.Value.Date, Convert.ToDecimal(txtVolume.Text),
                          Convert.ToDecimal(txtPrice.Text), txtStorageLocation.Text, cbSource.Text);
                    MessageBox.Show("تمت عملية الإضافة بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
