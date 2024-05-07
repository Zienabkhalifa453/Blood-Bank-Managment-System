
namespace BBMS.PL
{
    partial class FRM_BloodTransfusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BloodTransfusion));
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transfusion = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumOfProcesses = new System.Windows.Forms.Label();
            this.dgv_Transfusion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTransfusion = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbDonor = new System.Windows.Forms.GroupBox();
            this.txtBagId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCivil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbWithoutDonor = new System.Windows.Forms.RadioButton();
            this.btnTransfusion = new System.Windows.Forms.Button();
            this.rbDonor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transfusion)).BeginInit();
            this.grbTransfusion.SuspendLayout();
            this.grbDonor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.AllowUserToAddRows = false;
            this.dgv_Patient.AllowUserToDeleteRows = false;
            this.dgv_Patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Patient.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6,
            this.Column7,
            this.Transfusion});
            this.dgv_Patient.Location = new System.Drawing.Point(37, 121);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.ReadOnly = true;
            this.dgv_Patient.Size = new System.Drawing.Size(1266, 98);
            this.dgv_Patient.TabIndex = 22;
            this.dgv_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patient_CellContentClick);
            // 
            // PatientId
            // 
            this.PatientId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "الرقم";
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            this.PatientId.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المريض";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Civil_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "الرقم القومى";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BloodGroup";
            this.dataGridViewTextBoxColumn4.HeaderText = "فصيلة الدم";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 89;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "رقم التليفون";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 97;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Address";
            this.Column6.HeaderText = "العنوان";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "HospitalName";
            this.Column7.HeaderText = "المستشفى";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Transfusion
            // 
            this.Transfusion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Transfusion.HeaderText = "نقل دم";
            this.Transfusion.Image = ((System.Drawing.Image)(resources.GetObject("Transfusion.Image")));
            this.Transfusion.Name = "Transfusion";
            this.Transfusion.ReadOnly = true;
            this.Transfusion.Width = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(237, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 57);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الرقم القومي للمريض";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(121, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(234, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(347, 19);
            this.txtSearch.MaxLength = 14;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "نقل الدم لمريض";
            // 
            // lblNumOfProcesses
            // 
            this.lblNumOfProcesses.AutoSize = true;
            this.lblNumOfProcesses.ForeColor = System.Drawing.Color.Gray;
            this.lblNumOfProcesses.Location = new System.Drawing.Point(108, 395);
            this.lblNumOfProcesses.Name = "lblNumOfProcesses";
            this.lblNumOfProcesses.Size = new System.Drawing.Size(155, 19);
            this.lblNumOfProcesses.TabIndex = 24;
            this.lblNumOfProcesses.Text = "إجمالي العمليات خلال اليوم:";
            // 
            // dgv_Transfusion
            // 
            this.dgv_Transfusion.AllowUserToAddRows = false;
            this.dgv_Transfusion.AllowUserToDeleteRows = false;
            this.dgv_Transfusion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Transfusion.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Transfusion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Transfusion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transfusion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Transfusion.Location = new System.Drawing.Point(112, 417);
            this.dgv_Transfusion.Name = "dgv_Transfusion";
            this.dgv_Transfusion.ReadOnly = true;
            this.dgv_Transfusion.Size = new System.Drawing.Size(1082, 220);
            this.dgv_Transfusion.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "transfusion_id";
            this.Column1.HeaderText = "رقم العملية";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 92;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "BagId";
            this.Column2.HeaderText = "رقم الكيس";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 88;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "اسم المريض";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "transfusion_date";
            this.Column4.HeaderText = "تاريخ العملية";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 102;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "مسئول النقل";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grbTransfusion
            // 
            this.grbTransfusion.Controls.Add(this.button1);
            this.grbTransfusion.Controls.Add(this.grbDonor);
            this.grbTransfusion.Controls.Add(this.rbWithoutDonor);
            this.grbTransfusion.Controls.Add(this.btnTransfusion);
            this.grbTransfusion.Controls.Add(this.rbDonor);
            this.grbTransfusion.Location = new System.Drawing.Point(112, 225);
            this.grbTransfusion.Name = "grbTransfusion";
            this.grbTransfusion.Size = new System.Drawing.Size(1082, 154);
            this.grbTransfusion.TabIndex = 25;
            this.grbTransfusion.TabStop = false;
            this.grbTransfusion.Text = "عملية نقل الدم";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(228, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "الغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbDonor
            // 
            this.grbDonor.Controls.Add(this.txtBagId);
            this.grbDonor.Controls.Add(this.label3);
            this.grbDonor.Controls.Add(this.txtCivil);
            this.grbDonor.Controls.Add(this.label2);
            this.grbDonor.Location = new System.Drawing.Point(367, 34);
            this.grbDonor.Name = "grbDonor";
            this.grbDonor.Size = new System.Drawing.Size(452, 105);
            this.grbDonor.TabIndex = 1;
            this.grbDonor.TabStop = false;
            this.grbDonor.Text = "بيانات المتبرع";
            // 
            // txtBagId
            // 
            this.txtBagId.Location = new System.Drawing.Point(32, 63);
            this.txtBagId.MaxLength = 14;
            this.txtBagId.Name = "txtBagId";
            this.txtBagId.Size = new System.Drawing.Size(274, 26);
            this.txtBagId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "رقم الكيس البديل:";
            // 
            // txtCivil
            // 
            this.txtCivil.Location = new System.Drawing.Point(32, 31);
            this.txtCivil.MaxLength = 14;
            this.txtCivil.Name = "txtCivil";
            this.txtCivil.Size = new System.Drawing.Size(274, 26);
            this.txtCivil.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "الرقم القومى:";
            // 
            // rbWithoutDonor
            // 
            this.rbWithoutDonor.AutoSize = true;
            this.rbWithoutDonor.Location = new System.Drawing.Point(493, 11);
            this.rbWithoutDonor.Name = "rbWithoutDonor";
            this.rbWithoutDonor.Size = new System.Drawing.Size(87, 23);
            this.rbWithoutDonor.TabIndex = 0;
            this.rbWithoutDonor.TabStop = true;
            this.rbWithoutDonor.Text = "بدون متبرع";
            this.rbWithoutDonor.UseVisualStyleBackColor = true;
            this.rbWithoutDonor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnTransfusion
            // 
            this.btnTransfusion.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfusion.Image")));
            this.btnTransfusion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfusion.Location = new System.Drawing.Point(228, 77);
            this.btnTransfusion.Name = "btnTransfusion";
            this.btnTransfusion.Size = new System.Drawing.Size(133, 28);
            this.btnTransfusion.TabIndex = 2;
            this.btnTransfusion.Text = "نقل دم";
            this.btnTransfusion.UseVisualStyleBackColor = true;
            this.btnTransfusion.Click += new System.EventHandler(this.btnTransfusion_Click);
            // 
            // rbDonor
            // 
            this.rbDonor.AutoSize = true;
            this.rbDonor.Location = new System.Drawing.Point(609, 11);
            this.rbDonor.Name = "rbDonor";
            this.rbDonor.Size = new System.Drawing.Size(58, 23);
            this.rbDonor.TabIndex = 0;
            this.rbDonor.TabStop = true;
            this.rbDonor.Text = "متبرع";
            this.rbDonor.UseVisualStyleBackColor = true;
            this.rbDonor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FRM_BloodTransfusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 664);
            this.Controls.Add(this.grbTransfusion);
            this.Controls.Add(this.lblNumOfProcesses);
            this.Controls.Add(this.dgv_Transfusion);
            this.Controls.Add(this.dgv_Patient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FRM_BloodTransfusion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_BloodTransfusion";
            this.Load += new System.EventHandler(this.FRM_BloodTransfusion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transfusion)).EndInit();
            this.grbTransfusion.ResumeLayout(false);
            this.grbTransfusion.PerformLayout();
            this.grbDonor.ResumeLayout(false);
            this.grbDonor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumOfProcesses;
        private System.Windows.Forms.DataGridView dgv_Transfusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Transfusion;
        private System.Windows.Forms.GroupBox grbTransfusion;
        private System.Windows.Forms.GroupBox grbDonor;
        private System.Windows.Forms.TextBox txtBagId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCivil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbWithoutDonor;
        private System.Windows.Forms.RadioButton rbDonor;
        private System.Windows.Forms.Button btnTransfusion;
        private System.Windows.Forms.Button button1;
    }
}