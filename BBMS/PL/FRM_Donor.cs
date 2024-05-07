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
    public partial class FRM_Donor : Form
    {
        BL.Donor donor = new BL.Donor();
        private string Donor_Id = "";
        private static FRM_Donor frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Donor getDonorForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Donor();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_Donor()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dgv_Donor.DataSource = donor.GetAllDonors();
        }

        private void linkAddDonor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_ManageDonor donor = new FRM_ManageDonor();
            donor.state = "Add";
            donor.LastDobation = DateTime.Today;
            donor.ShowDialog();
        }

        private void dgv_Donor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Donor.Rows[e.RowIndex];
            Donor_Id = row.Cells["Column1"].Value.ToString();
            //Donor_Name = row.Cells["Column2"].Value.ToString();

            if (dgv_Donor.Columns[e.ColumnIndex].Name == "update")
            {
                if (MessageBox.Show("هل تريد تعديل هذا المتبرع؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FRM_ManageDonor donor = new FRM_ManageDonor();
                    donor.state = "Update";
                    donor.Id = Donor_Id;

                    string[] nameParts = row.Cells["Column2"].Value.ToString().Split(' ');
                    string[] BloodType = row.Cells["Column4"].Value.ToString().Split(' ');

                    donor.Fname = nameParts.Length > 0 ? nameParts[0] : "";
                    donor.Mname = nameParts.Length > 2 ? nameParts[1] : "";
                    donor.Lname = nameParts.Length > 1 ? nameParts[nameParts.Length - 1] : "";

                    donor.Civil_Id = row.Cells["Column3"].Value.ToString(); 
                    donor.Phone = row.Cells["Column6"].Value.ToString();
                    donor.Address = row.Cells["Column7"].Value.ToString();
                    donor.DonorRegion = row.Cells["Column8"].Value.ToString();

                    donor.BloodGroup = BloodType.Length > 0 ? BloodType[0] : "";
                    donor.RH = BloodType.Length > 1 ? BloodType[BloodType.Length - 1] : "";

                    donor.LastDobation = Convert.ToDateTime(row.Cells["Column5"].Value.ToString()).Date;

                    donor.ShowDialog();
                }
            }
            else if(dgv_Donor.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("هل تريد حذف هذا المتبرع بالفعل؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        donor.DeleteDonor(Convert.ToInt32(Donor_Id));
                        MessageBox.Show("تم حذف المتبرع", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dgv_Donor.DataSource = donor.GetAllDonors();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSearchDonor_TextChanged(object sender, EventArgs e)
        {
            this.dgv_Donor.DataSource =  donor.SeachDonor(txtSearchDonor.Text);
        }
    }
}
