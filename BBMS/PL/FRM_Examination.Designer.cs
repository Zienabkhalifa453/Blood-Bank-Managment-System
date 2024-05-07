
namespace BBMS.PL
{
    partial class FRM_Examination
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Examination));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddBlood = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbPulse = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPulse_Rate = new System.Windows.Forms.TextBox();
            this.txtHigh_Pressure = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonor_Id = new System.Windows.Forms.TextBox();
            this.txtCivil_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHomoglobin = new System.Windows.Forms.TextBox();
            this.txtLow_Pressure = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpExamination = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpExamination.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(105, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBlood
            // 
            this.btnAddBlood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBlood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBlood.Image")));
            this.btnAddBlood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBlood.Location = new System.Drawing.Point(244, 31);
            this.btnAddBlood.Name = "btnAddBlood";
            this.btnAddBlood.Size = new System.Drawing.Size(145, 28);
            this.btnAddBlood.TabIndex = 2;
            this.btnAddBlood.Text = "إضافة الدم";
            this.btnAddBlood.UseVisualStyleBackColor = true;
            this.btnAddBlood.Click += new System.EventHandler(this.btnAddBlood_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(534, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCancel);
            this.grpButtons.Controls.Add(this.btnAddBlood);
            this.grpButtons.Controls.Add(this.btnPrint);
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Location = new System.Drawing.Point(265, 559);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(804, 77);
            this.grpButtons.TabIndex = 6;
            this.grpButtons.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(395, 31);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 28);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // cbPulse
            // 
            this.cbPulse.FormattingEnabled = true;
            this.cbPulse.Items.AddRange(new object[] {
            "منتظم",
            "غير منتظم"});
            this.cbPulse.Location = new System.Drawing.Point(538, 109);
            this.cbPulse.Name = "cbPulse";
            this.cbPulse.Size = new System.Drawing.Size(130, 27);
            this.cbPulse.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(62, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "(100-60) ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(12, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "(100-60) mmHg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(443, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "(37.5-36) C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(460, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "(>50) Kg";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(440, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "(18-13) g/dl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(409, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "(180-90) mmHg";
            // 
            // txtPulse_Rate
            // 
            this.txtPulse_Rate.Location = new System.Drawing.Point(141, 107);
            this.txtPulse_Rate.Name = "txtPulse_Rate";
            this.txtPulse_Rate.Size = new System.Drawing.Size(130, 26);
            this.txtPulse_Rate.TabIndex = 4;
            this.txtPulse_Rate.Text = "90";
            // 
            // txtHigh_Pressure
            // 
            this.txtHigh_Pressure.Location = new System.Drawing.Point(141, 73);
            this.txtHigh_Pressure.Name = "txtHigh_Pressure";
            this.txtHigh_Pressure.Size = new System.Drawing.Size(130, 26);
            this.txtHigh_Pressure.TabIndex = 2;
            this.txtHigh_Pressure.Text = "80";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 240);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(656, 71);
            this.txtNotes.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(538, 323);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(130, 26);
            this.txtStatus.TabIndex = 0;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(538, 208);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(130, 26);
            this.txtTemp.TabIndex = 7;
            this.txtTemp.Text = "37";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonor_Id);
            this.groupBox1.Controls.Add(this.txtCivil_Id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(265, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المتبرع";
            // 
            // txtDonor_Id
            // 
            this.txtDonor_Id.Location = new System.Drawing.Point(62, 42);
            this.txtDonor_Id.Name = "txtDonor_Id";
            this.txtDonor_Id.ReadOnly = true;
            this.txtDonor_Id.Size = new System.Drawing.Size(247, 26);
            this.txtDonor_Id.TabIndex = 1;
            // 
            // txtCivil_Id
            // 
            this.txtCivil_Id.Location = new System.Drawing.Point(430, 42);
            this.txtCivil_Id.MaxLength = 14;
            this.txtCivil_Id.Name = "txtCivil_Id";
            this.txtCivil_Id.ReadOnly = true;
            this.txtCivil_Id.Size = new System.Drawing.Size(270, 26);
            this.txtCivil_Id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "رقم المتبرع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "الرقم القومى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Examination";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(538, 176);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(130, 26);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.Text = "75";
            // 
            // txtHomoglobin
            // 
            this.txtHomoglobin.Location = new System.Drawing.Point(538, 144);
            this.txtHomoglobin.Name = "txtHomoglobin";
            this.txtHomoglobin.Size = new System.Drawing.Size(130, 26);
            this.txtHomoglobin.TabIndex = 5;
            this.txtHomoglobin.Text = "15";
            // 
            // txtLow_Pressure
            // 
            this.txtLow_Pressure.Location = new System.Drawing.Point(538, 73);
            this.txtLow_Pressure.Name = "txtLow_Pressure";
            this.txtLow_Pressure.Size = new System.Drawing.Size(130, 26);
            this.txtLow_Pressure.TabIndex = 1;
            this.txtLow_Pressure.Text = "120";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(706, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "ملاحظات طبية:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "الضغط العالي:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(742, 326);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "مقبول؟";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(706, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "درجة الحرارة:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(739, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "الوزن:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "معدل النبض:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(739, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "النبض:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "الضغط المنخفض:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاريخ الفحص:";
            // 
            // grpExamination
            // 
            this.grpExamination.Controls.Add(this.cbPulse);
            this.grpExamination.Controls.Add(this.label11);
            this.grpExamination.Controls.Add(this.label8);
            this.grpExamination.Controls.Add(this.label17);
            this.grpExamination.Controls.Add(this.label15);
            this.grpExamination.Controls.Add(this.label13);
            this.grpExamination.Controls.Add(this.label6);
            this.grpExamination.Controls.Add(this.txtPulse_Rate);
            this.grpExamination.Controls.Add(this.txtHigh_Pressure);
            this.grpExamination.Controls.Add(this.txtNotes);
            this.grpExamination.Controls.Add(this.txtStatus);
            this.grpExamination.Controls.Add(this.txtTemp);
            this.grpExamination.Controls.Add(this.txtWeight);
            this.grpExamination.Controls.Add(this.txtHomoglobin);
            this.grpExamination.Controls.Add(this.txtLow_Pressure);
            this.grpExamination.Controls.Add(this.label18);
            this.grpExamination.Controls.Add(this.label7);
            this.grpExamination.Controls.Add(this.label19);
            this.grpExamination.Controls.Add(this.label16);
            this.grpExamination.Controls.Add(this.dateTimePicker1);
            this.grpExamination.Controls.Add(this.label14);
            this.grpExamination.Controls.Add(this.label10);
            this.grpExamination.Controls.Add(this.label12);
            this.grpExamination.Controls.Add(this.label9);
            this.grpExamination.Controls.Add(this.label5);
            this.grpExamination.Controls.Add(this.label3);
            this.grpExamination.Location = new System.Drawing.Point(265, 181);
            this.grpExamination.Name = "grpExamination";
            this.grpExamination.Size = new System.Drawing.Size(804, 372);
            this.grpExamination.TabIndex = 5;
            this.grpExamination.TabStop = false;
            this.grpExamination.Text = "Examination";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(714, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "هيموجلوبين:";
            // 
            // FRM_Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 664);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpExamination);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FRM_Examination";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Examination";
            this.Load += new System.EventHandler(this.FRM_Examination_Load);
            this.grpButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpExamination.ResumeLayout(false);
            this.grpExamination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddBlood;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbPulse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPulse_Rate;
        private System.Windows.Forms.TextBox txtHigh_Pressure;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHomoglobin;
        private System.Windows.Forms.TextBox txtLow_Pressure;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpExamination;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDonor_Id;
        private System.Windows.Forms.TextBox txtCivil_Id;
    }
}