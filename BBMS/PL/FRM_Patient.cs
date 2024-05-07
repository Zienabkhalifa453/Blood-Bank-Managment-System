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
    public partial class FRM_Patient : Form
    {
        BL.Patient patient = new BL.Patient();
        private string Id = "";
        private static FRM_Patient frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Patient getPatientForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Patient();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_Patient()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dgv_Patient.DataSource = patient.SelectPatient();
        }

        private void linkAddDonor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_ManagePatient patient = new FRM_ManagePatient();
            patient.ShowDialog();
        }

        private void dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Patient.Rows[e.RowIndex];
            Id = row.Cells["Column1"].Value.ToString();

            if (dgv_Patient.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("هل تريد حذف هذا المريض؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        patient.DeletePatient(Convert.ToInt32(Id));
                        this.dgv_Patient.DataSource = patient.SelectPatient();
                        MessageBox.Show("تم الحذف بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (dgv_Patient.Columns[e.ColumnIndex].Name == "update")
            {
                FRM_ManagePatient patient = new FRM_ManagePatient();

                patient.Id = Convert.ToInt32(Id);
                patient.PatientName = row.Cells["Column2"].Value.ToString();
                patient.Civil_Id = row.Cells["Column3"].Value.ToString();

                string[] BloodType = row.Cells["Column4"].Value.ToString().Split(' ');
                patient.BloodGroup = BloodType.Length > 0 ? BloodType[0] : "";
                patient.RH = BloodType.Length > 1 ? BloodType[BloodType.Length - 1] : "";

                patient.Phone = row.Cells["Column5"].Value.ToString();
                patient.Address = row.Cells["Column6"].Value.ToString();
                patient.Hospital = row.Cells["Column7"].Value.ToString();

                patient.btnAdd.Text = "تعديل";
                patient.state = "Update";
                patient.ShowDialog();
            }
        }

        private void txtSearchDonor_TextChanged(object sender, EventArgs e)
        {
            this.dgv_Patient.DataSource = patient.SearchPatient(txtSearchPatient.Text);
        }
    }
}
