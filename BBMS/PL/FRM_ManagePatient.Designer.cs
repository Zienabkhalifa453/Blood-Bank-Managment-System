
namespace BBMS.PL
{
    partial class FRM_ManagePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ManagePatient));
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpPatientData = new System.Windows.Forms.GroupBox();
            this.cbHospital = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbRh = new System.Windows.Forms.ComboBox();
            this.labelRH = new System.Windows.Forms.Label();
            this.cbBloodGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCivil_Id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpPatientData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(706, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "إضافة مريض جديد";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 32);
            this.panel1.TabIndex = 1;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCancel);
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Location = new System.Drawing.Point(23, 541);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(769, 62);
            this.grpButtons.TabIndex = 11;
            this.grpButtons.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(270, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(407, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpPatientData
            // 
            this.grpPatientData.Controls.Add(this.cbHospital);
            this.grpPatientData.Controls.Add(this.groupBox4);
            this.grpPatientData.Controls.Add(this.pictureBox1);
            this.grpPatientData.Controls.Add(this.cbRh);
            this.grpPatientData.Controls.Add(this.labelRH);
            this.grpPatientData.Controls.Add(this.cbBloodGroup);
            this.grpPatientData.Controls.Add(this.label2);
            this.grpPatientData.Controls.Add(this.labelBloodType);
            this.grpPatientData.Controls.Add(this.txtAddress);
            this.grpPatientData.Controls.Add(this.label7);
            this.grpPatientData.Controls.Add(this.txtPhone);
            this.grpPatientData.Controls.Add(this.labelPhone);
            this.grpPatientData.Controls.Add(this.txtName);
            this.grpPatientData.Controls.Add(this.labelName);
            this.grpPatientData.Location = new System.Drawing.Point(23, 139);
            this.grpPatientData.Name = "grpPatientData";
            this.grpPatientData.Size = new System.Drawing.Size(769, 396);
            this.grpPatientData.TabIndex = 10;
            this.grpPatientData.TabStop = false;
            this.grpPatientData.Text = "بيانات المريض";
            // 
            // cbHospital
            // 
            this.cbHospital.FormattingEnabled = true;
            this.cbHospital.Location = new System.Drawing.Point(237, 356);
            this.cbHospital.Name = "cbHospital";
            this.cbHospital.Size = new System.Drawing.Size(432, 27);
            this.cbHospital.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtCity);
            this.groupBox4.Controls.Add(this.txtGender);
            this.groupBox4.Controls.Add(this.txtAge);
            this.groupBox4.Controls.Add(this.txtDOB);
            this.groupBox4.Location = new System.Drawing.Point(145, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(534, 89);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "المحافظة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "النوع:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "العمر:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "تاريخ الميلاد:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(6, 46);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(169, 26);
            this.txtCity.TabIndex = 0;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(181, 46);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(75, 26);
            this.txtGender.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(262, 46);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(75, 26);
            this.txtAge.TabIndex = 0;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(343, 46);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(185, 26);
            this.txtDOB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cbRh
            // 
            this.cbRh.FormattingEnabled = true;
            this.cbRh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbRh.Location = new System.Drawing.Point(237, 301);
            this.cbRh.Name = "cbRh";
            this.cbRh.Size = new System.Drawing.Size(175, 27);
            this.cbRh.TabIndex = 8;
            // 
            // labelRH
            // 
            this.labelRH.AutoSize = true;
            this.labelRH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRH.Location = new System.Drawing.Point(418, 304);
            this.labelRH.Name = "labelRH";
            this.labelRH.Size = new System.Drawing.Size(39, 19);
            this.labelRH.TabIndex = 15;
            this.labelRH.Text = "RH:";
            // 
            // cbBloodGroup
            // 
            this.cbBloodGroup.FormattingEnabled = true;
            this.cbBloodGroup.Items.AddRange(new object[] {
            "O",
            "A",
            "B",
            "AB"});
            this.cbBloodGroup.Location = new System.Drawing.Point(501, 301);
            this.cbBloodGroup.Name = "cbBloodGroup";
            this.cbBloodGroup.Size = new System.Drawing.Size(165, 27);
            this.cbBloodGroup.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المستشفى:";
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodType.Location = new System.Drawing.Point(683, 302);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(70, 19);
            this.labelBloodType.TabIndex = 0;
            this.labelBloodType.Text = "فصيلة الدم:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(237, 212);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(429, 75);
            this.txtAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(700, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "العنوان:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(409, 171);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 26);
            this.txtPhone.TabIndex = 4;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(675, 178);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 19);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "رقم التليفون:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(534, 26);
            this.txtName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(685, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "إسم المريض:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtCivil_Id);
            this.groupBox1.Location = new System.Drawing.Point(23, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 99);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الرقم القومي للمريض";
            // 
            // txtCivil_Id
            // 
            this.txtCivil_Id.Location = new System.Drawing.Point(238, 19);
            this.txtCivil_Id.MaxLength = 14;
            this.txtCivil_Id.Name = "txtCivil_Id";
            this.txtCivil_Id.Size = new System.Drawing.Size(325, 26);
            this.txtCivil_Id.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(294, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "الغاء";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(407, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "بحث";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 637);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpPatientData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FRM_ManagePatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ManagePatient";
            this.Load += new System.EventHandler(this.FRM_ManagePatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grpPatientData.ResumeLayout(false);
            this.grpPatientData.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpPatientData;
        private System.Windows.Forms.ComboBox cbHospital;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbRh;
        private System.Windows.Forms.Label labelRH;
        private System.Windows.Forms.ComboBox cbBloodGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCivil_Id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnAdd;
    }
}