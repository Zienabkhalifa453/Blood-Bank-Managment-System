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
    public partial class FRM_Blood : Form
    {
        BL.Blood blood = new BL.Blood();
        private int NumOfBags;
        public FRM_Blood()
        {
            InitializeComponent();
        }

        private void FRM_Blood_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            NumOfBags = Convert.ToInt32(DAL.ExecuteScalar("SELECT COUNT(*) FROM tblBloodBags WHERE Status <> 'تم الصرف';", null));
            this.dgv_Blood.DataSource = blood.SelectBlood("SELECT BagID, (BloodType + ' ' + RhFactor) AS BloodType, CollectionDate, ExpirationDate, Volume, Price, DonorID, StorageLocation, Donation_Source, Status, Reserved FROM tblBloodBags WHERE Status <> 'تم الصرف' ;");
            lblNumOfBags.Text += NumOfBags;
        }
    }
}
