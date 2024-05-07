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
    public partial class FRM_Hospital : Form
    {
        private static FRM_Hospital frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        
        public static FRM_Hospital getHospitalForm
        {
            get
            {
                if(frm == null)
                {
                    frm = new FRM_Hospital();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.Hospital hospital = new BL.Hospital();
        private string Id = "";
        public FRM_Hospital()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dgv_Hospital.DataSource = hospital.SelectHospital();
        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_ManageHospital hospital = new FRM_ManageHospital();
            hospital.ShowAddButton = true;
            hospital.ShowUpdateButton = false;
            hospital.location = new Point(136, 417);
            hospital.ShowDialog();
        }

        private void dgv_Hospital_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_Hospital.Rows[e.RowIndex];
            Id = row.Cells["Column1"].Value.ToString();

            if (dgv_Hospital.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("هل تريد حذف هذه المستشفى؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        hospital.DeleteHospital(Convert.ToInt32(Id));
                        this.dgv_Hospital.DataSource = hospital.SelectHospital();
                        MessageBox.Show("تم الحذف بنجاح.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else if (dgv_Hospital.Columns[e.ColumnIndex].Name == "update")
            {
                FRM_ManageHospital hospital = new FRM_ManageHospital();
                hospital.ShowAddButton = false;
                hospital.ShowUpdateButton = true;
                hospital.location = new Point(235, 417);

                hospital.Id = Convert.ToInt32(Id);
                hospital.HospitalName = row.Cells["Column2"].Value.ToString();
                hospital.Address = row.Cells["Column3"].Value.ToString();
                hospital.City = row.Cells["Column4"].Value.ToString();
                hospital.PostalCode = row.Cells["Column5"].Value.ToString();
                hospital.Phone = row.Cells["Column6"].Value.ToString();
                hospital.Email = row.Cells["Column7"].Value.ToString();
                hospital.Website = row.Cells["Column8"].Value.ToString();

                hospital.ShowDialog();
            }
        }

        private void txtSearchDonor_TextChanged(object sender, EventArgs e)
        {
             this.dgv_Hospital.DataSource = hospital.SearchHopital(txtSearchHospital.Text);
        }
    }
}
