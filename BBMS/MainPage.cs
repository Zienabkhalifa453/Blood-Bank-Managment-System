using BBMS.DAL;
using BBMS.PL;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class MainPage : Form
    {
        private static MainPage frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static MainPage getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new MainPage();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public MainPage()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        public void AddChildFormToPanel(Form childForm, Panel parentPanel)
        {
            // Remove any existing child forms from the panel
            foreach (Control control in parentPanel.Controls)
            {
                if (control is Form form)
                {
                    form.Hide();
                    parentPanel.Controls.Remove(form);
                    form.Dispose();
                }
            }

            // Add the new child form to the panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void إدارةالمتبرعينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FRM_Donor();
            Panel parentPanel = this.ParentPanel; 
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void إدارةالمستشفياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FRM_Hospital();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void إدارةالمرضىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FRM_Patient();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void تسجيلمريضجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ManagePatient patient = new FRM_ManagePatient();
            patient.ShowDialog();
        }

        private void إدخالتبرعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Donate childForm = new FRM_Donate();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void تسجيلمتبرعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ManageDonor donor = new FRM_ManageDonor();
            donor.state = "Add";
            donor.LastDobation = DateTime.Today;
            donor.ShowDialog();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            FRM_MainPage childForm = new FRM_MainPage();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void إدارةمخزونالدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Blood childForm = new FRM_Blood();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void تسجيلنتيجةإختبارالدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BloodTestResult childForm = new FRM_BloodTestResult();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void نقلدملمريضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BloodTransfusion childForm = new FRM_BloodTransfusion();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void حجزكيسدملمريضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BloodReservation childForm = new FRM_BloodReservation();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void إدارةأكياسالدمالمحجوزةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ManageReservation childForm = new FRM_ManageReservation();
            Panel parentPanel = this.ParentPanel;
            AddChildFormToPanel(childForm, parentPanel);
        }

        private void تقريرعبواتالدمالمحجوزةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Query to retrieve data from the database
            var query = "SELECT r.ReservationID AS 'الرقم', p.Name AS 'Patient Name', r.BloodBagID AS 'Blood Bag ID', r.ReservationDate AS 'Reservation Date', r.ReservedBy AS 'Reserved By' FROM tblReservations r INNER JOIN tblPatient p ON r.PatientID = p.PatientId WHERE r.Status = 'قيد الانتظار'";

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);

           
            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();

           
            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            /*Set the page border properties
            wordDoc.PageSetup.PageBorders.LineStyle = WdLineStyle.wdLineStyleSingle;
            wordDoc.PageSetup.PageBorders.LineWidth = WdLineWidth.wdLineWidth150pt;*/
            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);
                   
                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }

        private void الرصيدالحاليلبنكالدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Query to retrieve data from the database
            var query = "SELECT BagID AS 'رقم الكيس', (BloodType + RhFactor) AS 'الفصيلة', CollectionDate AS 'تاريخ الدخول',ExpirationDate AS 'تاريخ إنتهاء الصلاحية', Volume AS 'الحجم', Price AS 'السعر' FROM tblBloodBags WHERE Status = 'صالحة' AND Reserved = 0; ";

            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);

            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();

            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);
                   
                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }

        private void تقريرعبواتالدمالغيرمختبرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = @"SELECT BagID AS 'رقم الكيس',
	           (BloodType + RhFactor) AS 'الفصيلة',
	           CollectionDate AS 'تاريخ الدخول',
	           ExpirationDate AS 'تاريخ إنتهاء الصلاحية',
	           Volume AS 'الحجم',
	           Price AS 'السعر' FROM tblBloodBags
               WHERE Status = 'غير مختبر';";
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);


            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();


            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            /*Set the page border properties
            wordDoc.PageSetup.PageBorders.LineStyle = WdLineStyle.wdLineStyleSingle;
            wordDoc.PageSetup.PageBorders.LineWidth = WdLineWidth.wdLineWidth150pt;*/
            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);

                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }

        private void تقريرأكياسالدمToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var query = @"SELECT (BloodType + RhFactor) AS 'الفصيلة', COUNT(*) AS 'الكمية'  
            FROM tblBloodBags
            WHERE Status = 'صالحة' AND Reserved = 0
            GROUP BY BloodType + RhFactor";
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);


            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();


            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            /*Set the page border properties
            wordDoc.PageSetup.PageBorders.LineStyle = WdLineStyle.wdLineStyleSingle;
            wordDoc.PageSetup.PageBorders.LineWidth = WdLineWidth.wdLineWidth150pt;*/
            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);

                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }

        private void تقريرعملياتنقلالدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = @"SELECT transfusion_id AS 'رقم العملية',
		            BagId AS 'رقم الكيس',
		            p.Name AS 'إسم المريض',
		            transfusion_date AS 'تاريخ العملية',
		            t.Status AS 'نوع العملية' 
                    FROM tblTransfusion t
                    INNER JOIN tblPatient p
                    ON t.recipient_id = p.PatientId;
                    ";
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);


            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();


            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            /*Set the page border properties
            wordDoc.PageSetup.PageBorders.LineStyle = WdLineStyle.wdLineStyleSingle;
            wordDoc.PageSetup.PageBorders.LineWidth = WdLineWidth.wdLineWidth150pt;*/
            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);

                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }

        private void تقريرعملياتالدفعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = @"SELECT Id AS 'رقم الدفع',
	           TransfusionId AS 'رقم عملية النقل',
	           Amount AS 'المبلغ' 
               FROM tblPayment;";
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);


            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();


            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            /*Set the page border properties
            wordDoc.PageSetup.PageBorders.LineStyle = WdLineStyle.wdLineStyleSingle;
            wordDoc.PageSetup.PageBorders.LineWidth = WdLineWidth.wdLineWidth150pt;*/
            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);

                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }

        private void تقريرالعبواتمنتهيةالصلاحيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = @"SELECT BagID AS 'رقم الكيس',
	           (BloodType + RhFactor) AS 'الفصيلة',
	           ExpirationDate AS 'تاريخ إنتهاء الصلاحية'
               FROM tblBloodBags
               WHERE DATEDIFF(day, ExpirationDate, CollectionDate) >= 60;";
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            dataAccessLayer.Open();

            // Retrieve the data from the database
            var dataTable = dataAccessLayer.SelectQuery(query);


            // Create Word report
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();
            wordDoc.Activate();


            //Set animation status for word application  
            wordApp.ShowAnimation = false;
            foreach (Section section in wordDoc.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 15;
                headerRange.Font.Bold = 1;
                headerRange.Text = "Report";
            }

            /*Set the page border properties
            wordDoc.PageSetup.PageBorders.LineStyle = WdLineStyle.wdLineStyleSingle;
            wordDoc.PageSetup.PageBorders.LineWidth = WdLineWidth.wdLineWidth150pt;*/
            // Add table to the document
            var tableRange = wordDoc.Range();
            tableRange.InsertParagraphAfter();
            var wordTable = wordDoc.Tables.Add(tableRange, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            wordTable.Borders.Enable = 1; // Enable borders
            wordTable.AllowAutoFit = true; // Enable auto-fit to content
            wordTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow); // Auto-fit to window size
            wordTable.Rows.Height = 10; // Set row height to 10 points

            // Populate the header cells of the table
            for (var col = 0; col < dataTable.Columns.Count; col++)
            {
                var headerCell = wordTable.Cell(1, dataTable.Columns.Count - col);
                headerCell.Range.Text = dataTable.Columns[col].ColumnName;
                headerCell.Range.Font.Bold = 1; // Make the header text bold for the first column only
                headerCell.Range.Font.Name = "verdana"; // Set the font name to Verdana
                headerCell.Range.Font.Size = 10; // Set the font size to 10
                headerCell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; // Center the text within the cell
                headerCell.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto; // Auto-adjust cell width
            }

            // Populate the data cells of the table
            for (var row = 0; row < dataTable.Rows.Count; row++)
            {
                for (var col = dataTable.Columns.Count - 1; col >= 0; col--)
                {
                    var dataCell = wordTable.Cell(row + 2, dataTable.Columns.Count - col);

                    dataCell.Range.Text = dataTable.Rows[row][col].ToString();
                    dataCell.Range.Font.Bold = 0; // Make the first row of data cells bold
                }
            }

            // Center align the table in the document
            tableRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            // Show the document in Word
            wordApp.Visible = true;

            // Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordTable);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

            dataAccessLayer.Close();
        }
    }
}
