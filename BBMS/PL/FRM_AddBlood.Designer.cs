
namespace BBMS.PL
{
    partial class FRM_AddBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddBlood));
            this.grpBloodInfo = new System.Windows.Forms.GroupBox();
            this.txtDonorId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCollection = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtExpiration = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStorageLocation = new System.Windows.Forms.TextBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBloodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBloodInfo
            // 
            this.grpBloodInfo.Controls.Add(this.cbSource);
            this.grpBloodInfo.Controls.Add(this.dtExpiration);
            this.grpBloodInfo.Controls.Add(this.dtCollection);
            this.grpBloodInfo.Controls.Add(this.label3);
            this.grpBloodInfo.Controls.Add(this.txtStorageLocation);
            this.grpBloodInfo.Controls.Add(this.txtPrice);
            this.grpBloodInfo.Controls.Add(this.txtVolume);
            this.grpBloodInfo.Controls.Add(this.label9);
            this.grpBloodInfo.Controls.Add(this.label7);
            this.grpBloodInfo.Controls.Add(this.label8);
            this.grpBloodInfo.Controls.Add(this.label2);
            this.grpBloodInfo.Controls.Add(this.label6);
            this.grpBloodInfo.Controls.Add(this.label5);
            this.grpBloodInfo.Controls.Add(this.label4);
            this.grpBloodInfo.Location = new System.Drawing.Point(282, 190);
            this.grpBloodInfo.Name = "grpBloodInfo";
            this.grpBloodInfo.Size = new System.Drawing.Size(769, 291);
            this.grpBloodInfo.TabIndex = 0;
            this.grpBloodInfo.TabStop = false;
            this.grpBloodInfo.Text = "بيانات كيس الدم";
            // 
            // txtDonorId
            // 
            this.txtDonorId.Location = new System.Drawing.Point(235, 34);
            this.txtDonorId.Name = "txtDonorId";
            this.txtDonorId.ReadOnly = true;
            this.txtDonorId.Size = new System.Drawing.Size(295, 26);
            this.txtDonorId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاريخ التبرع:";
            // 
            // dtCollection
            // 
            this.dtCollection.Location = new System.Drawing.Point(331, 36);
            this.dtCollection.Name = "dtCollection";
            this.dtCollection.Size = new System.Drawing.Size(289, 26);
            this.dtCollection.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاريخ إنتهاء الصلاحية:";
            // 
            // dtExpiration
            // 
            this.dtExpiration.Location = new System.Drawing.Point(331, 80);
            this.dtExpiration.Name = "dtExpiration";
            this.dtExpiration.Size = new System.Drawing.Size(289, 26);
            this.dtExpiration.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "الحجم:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(461, 197);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(159, 26);
            this.txtVolume.TabIndex = 1;
            this.txtVolume.Text = "450";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(420, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "(ml)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "السعر:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(405, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "(EGP)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(461, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 26);
            this.txtPrice.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(670, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "مكان التخزين:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(678, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "مكان التبرع:";
            // 
            // txtStorageLocation
            // 
            this.txtStorageLocation.Location = new System.Drawing.Point(331, 158);
            this.txtStorageLocation.Name = "txtStorageLocation";
            this.txtStorageLocation.Size = new System.Drawing.Size(289, 26);
            this.txtStorageLocation.TabIndex = 1;
            this.txtStorageLocation.Text = "بنك الدم الرئيسي";
            // 
            // cbSource
            // 
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] {
            "بنك الدم",
            "الحملات"});
            this.cbSource.Location = new System.Drawing.Point(331, 119);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(289, 27);
            this.cbSource.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "إضافة كيس دم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(731, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnCancel);
            this.grpButtons.Controls.Add(this.btnPrintLabel);
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Location = new System.Drawing.Point(282, 482);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(769, 62);
            this.grpButtons.TabIndex = 8;
            this.grpButtons.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(191, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintLabel.Image")));
            this.btnPrintLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintLabel.Location = new System.Drawing.Point(330, 21);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(133, 28);
            this.btnPrintLabel.TabIndex = 1;
            this.btnPrintLabel.Text = "Label";
            this.btnPrintLabel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(469, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDonorId);
            this.groupBox2.Location = new System.Drawing.Point(282, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 83);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "رقم المتبرع";
            // 
            // FRM_AddBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpBloodInfo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FRM_AddBlood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AddBlood";
            this.Load += new System.EventHandler(this.FRM_AddBlood_Load);
            this.grpBloodInfo.ResumeLayout(false);
            this.grpBloodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBloodInfo;
        private System.Windows.Forms.TextBox txtDonorId;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.DateTimePicker dtExpiration;
        private System.Windows.Forms.DateTimePicker dtCollection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStorageLocation;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}