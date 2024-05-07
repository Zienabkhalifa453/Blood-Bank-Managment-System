
namespace BBMS.PL
{
    partial class FRM_ManageDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ManageDonor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpDonorData = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtLastDonation = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.cbRh = new System.Windows.Forms.ComboBox();
            this.labelRH = new System.Windows.Forms.Label();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDonorData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(708, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "إضافة متبرع جديد";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الرقم القومي للمتبرع";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(238, 19);
            this.txtSearch.MaxLength = 14;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // grpDonorData
            // 
            this.grpDonorData.Controls.Add(this.textBox1);
            this.grpDonorData.Controls.Add(this.groupBox4);
            this.grpDonorData.Controls.Add(this.txtStatus);
            this.grpDonorData.Controls.Add(this.pictureBox1);
            this.grpDonorData.Controls.Add(this.dtLastDonation);
            this.grpDonorData.Controls.Add(this.labelDate);
            this.grpDonorData.Controls.Add(this.cbRh);
            this.grpDonorData.Controls.Add(this.labelRH);
            this.grpDonorData.Controls.Add(this.cbBloodType);
            this.grpDonorData.Controls.Add(this.label2);
            this.grpDonorData.Controls.Add(this.labelBloodType);
            this.grpDonorData.Controls.Add(this.txtRegion);
            this.grpDonorData.Controls.Add(this.labelRegion);
            this.grpDonorData.Controls.Add(this.txtAddress);
            this.grpDonorData.Controls.Add(this.label7);
            this.grpDonorData.Controls.Add(this.txtPhone);
            this.grpDonorData.Controls.Add(this.labelPhone);
            this.grpDonorData.Controls.Add(this.txtLname);
            this.grpDonorData.Controls.Add(this.txtMname);
            this.grpDonorData.Controls.Add(this.txtFname);
            this.grpDonorData.Controls.Add(this.labelName);
            this.grpDonorData.Location = new System.Drawing.Point(12, 149);
            this.grpDonorData.Name = "grpDonorData";
            this.grpDonorData.Size = new System.Drawing.Size(769, 396);
            this.grpDonorData.TabIndex = 8;
            this.grpDonorData.TabStop = false;
            this.grpDonorData.Text = "بيانات المتبرع";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 26);
            this.textBox1.TabIndex = 20;
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
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(250, 360);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(429, 26);
            this.txtStatus.TabIndex = 18;
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
            // dtLastDonation
            // 
            this.dtLastDonation.Location = new System.Drawing.Point(375, 167);
            this.dtLastDonation.Name = "dtLastDonation";
            this.dtLastDonation.Size = new System.Drawing.Size(304, 26);
            this.dtLastDonation.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(693, 167);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 19);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "أخر تبرع:";
            // 
            // cbRh
            // 
            this.cbRh.FormattingEnabled = true;
            this.cbRh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbRh.Location = new System.Drawing.Point(250, 323);
            this.cbRh.Name = "cbRh";
            this.cbRh.Size = new System.Drawing.Size(175, 27);
            this.cbRh.TabIndex = 8;
            // 
            // labelRH
            // 
            this.labelRH.AutoSize = true;
            this.labelRH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRH.Location = new System.Drawing.Point(431, 326);
            this.labelRH.Name = "labelRH";
            this.labelRH.Size = new System.Drawing.Size(39, 19);
            this.labelRH.TabIndex = 15;
            this.labelRH.Text = "RH:";
            // 
            // cbBloodType
            // 
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Items.AddRange(new object[] {
            "O",
            "A",
            "B",
            "AB"});
            this.cbBloodType.Location = new System.Drawing.Point(514, 323);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.Size = new System.Drawing.Size(165, 27);
            this.cbBloodType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "حالة المتبرع:";
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodType.Location = new System.Drawing.Point(693, 324);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(70, 19);
            this.labelBloodType.TabIndex = 0;
            this.labelBloodType.Text = "فصيلة الدم:";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(25, 252);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(152, 26);
            this.txtRegion.TabIndex = 6;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion.Location = new System.Drawing.Point(183, 259);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(54, 19);
            this.labelRegion.TabIndex = 11;
            this.labelRegion.Text = "المنطقة:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(250, 241);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(429, 75);
            this.txtAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(710, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "العنوان:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(422, 204);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 26);
            this.txtPhone.TabIndex = 4;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(685, 211);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 19);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "رقم التليفون:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(266, 37);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(125, 26);
            this.txtLname.TabIndex = 2;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(397, 37);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(133, 26);
            this.txtMname.TabIndex = 1;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(536, 37);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(143, 26);
            this.txtFname.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(685, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "إسم المتبرع:";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCancel);
            this.grpButtons.Controls.Add(this.btnPrint);
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Location = new System.Drawing.Point(12, 551);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(769, 62);
            this.grpButtons.TabIndex = 9;
            this.grpButtons.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(187, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(326, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 28);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(465, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(291, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 3;
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
            this.button3.Location = new System.Drawing.Point(404, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "بحث";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_ManageDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 637);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpDonorData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ManageDonor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة متبرع جديد";
            this.Load += new System.EventHandler(this.FRM_AddDonor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDonorData.ResumeLayout(false);
            this.grpDonorData.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpDonorData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtLastDonation;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox cbRh;
        private System.Windows.Forms.Label labelRH;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}