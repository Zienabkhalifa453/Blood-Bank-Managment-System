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
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("server= LAPTOP-BBAHT6CG ;  DataBase=BBMS_DB ; Integrated Security=true");
      
        public Form1()
        {
            InitializeComponent();
            conn.Open();
           
        }
        private void chart8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
