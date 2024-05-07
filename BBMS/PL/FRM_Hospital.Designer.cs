
namespace BBMS.PL
{
    partial class FRM_Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Hospital));
            this.dgv_Hospital = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.linkAdd = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchHospital = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Hospital
            // 
            this.dgv_Hospital.AllowUserToAddRows = false;
            this.dgv_Hospital.AllowUserToDeleteRows = false;
            this.dgv_Hospital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hospital.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Hospital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Hospital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hospital.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.update,
            this.Delete});
            this.dgv_Hospital.Location = new System.Drawing.Point(42, 84);
            this.dgv_Hospital.Name = "dgv_Hospital";
            this.dgv_Hospital.ReadOnly = true;
            this.dgv_Hospital.Size = new System.Drawing.Size(1266, 535);
            this.dgv_Hospital.TabIndex = 1;
            this.dgv_Hospital.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hospital_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "HospitalID";
            this.Column1.HeaderText = "الرقم";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HospitalName";
            this.Column2.HeaderText = "اسم المستشفى";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "العنوان";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "City";
            this.Column4.HeaderText = "المحافظة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 81;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "ZipPostalCode";
            this.Column5.HeaderText = "الرمز بريدي";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 97;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "PhoneNumber";
            this.Column6.HeaderText = "رقم التليفون";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 97;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EmailAddress";
            this.Column7.HeaderText = "البريد الالكترونى";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "Website";
            this.Column8.HeaderText = "Website";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 95;
            // 
            // update
            // 
            this.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.update.HeaderText = "تعديل";
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Width = 41;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete.HeaderText = "حذف";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 40;
            // 
            // linkAdd
            // 
            this.linkAdd.AutoSize = true;
            this.linkAdd.Location = new System.Drawing.Point(78, 51);
            this.linkAdd.Name = "linkAdd";
            this.linkAdd.Size = new System.Drawing.Size(121, 19);
            this.linkAdd.TabIndex = 2;
            this.linkAdd.TabStop = true;
            this.linkAdd.Text = "إضافة مستشفى جديدة";
            this.linkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdd_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchHospital
            // 
            this.txtSearchHospital.Location = new System.Drawing.Point(448, 31);
            this.txtSearchHospital.Name = "txtSearchHospital";
            this.txtSearchHospital.Size = new System.Drawing.Size(402, 26);
            this.txtSearchHospital.TabIndex = 3;
            this.txtSearchHospital.TextChanged += new System.EventHandler(this.txtSearchDonor_TextChanged);
            // 
            // FRM_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchHospital);
            this.Controls.Add(this.linkAdd);
            this.Controls.Add(this.dgv_Hospital);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FRM_Hospital";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchHospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.DataGridView dgv_Hospital;
    }
}