using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    partial class FrmChange
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
            this.lblServicelist = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNow = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.cboService_ = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboType_ = new System.Windows.Forms.ComboBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.grpboxDetails = new System.Windows.Forms.GroupBox();
            this.lblService_ = new System.Windows.Forms.Label();
            this.txtRequestID_ = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dtpStart_ = new System.Windows.Forms.DateTimePicker();
            this.lblAmount_ = new System.Windows.Forms.Label();
            this.lblDescription_ = new System.Windows.Forms.Label();
            this.lblStart_ = new System.Windows.Forms.Label();
            this.lblStatus_ = new System.Windows.Forms.Label();
            this.lblModel_ = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.grpboxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServicelist
            // 
            this.lblServicelist.AutoSize = true;
            this.lblServicelist.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServicelist.Location = new System.Drawing.Point(747, 350);
            this.lblServicelist.Name = "lblServicelist";
            this.lblServicelist.Size = new System.Drawing.Size(169, 27);
            this.lblServicelist.TabIndex = 1;
            this.lblServicelist.Text = "Service Type List";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "No                             Service Type                                      " +
                "                   Normal                 Urgent",
            "",
            " 1              Remove virus, malware or spyware                                 " +
                "   RM 50                   RM80",
            " 2          Troubleshot and fix computer running slow                        RM 6" +
                "0                   RM90",
            " 3                      Laptop screen replacement                                " +
                "        RM 380                RM430",
            " 4                   Laptop keyboard replacement                                 " +
                "     RM 160                RM200",
            " 5                      Laptop battery replacement                               " +
                "        RM 180                RM210",
            " 6           Operating System Format and Installation                          RM" +
                " 100                RM150",
            " 7                         Data backup and recovery                              " +
                "           RM 80                 RM130",
            " 8                       Internet connectivity issues                            " +
                "             RM 70                 RM100"});
            this.listBox1.Location = new System.Drawing.Point(747, 380);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(693, 224);
            this.listBox1.TabIndex = 2;
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNow.Location = new System.Drawing.Point(67, 124);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(133, 23);
            this.lblNow.TabIndex = 3;
            this.lblNow.Text = "Now Selecting:";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNew.Location = new System.Drawing.Point(39, 163);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(160, 23);
            this.lblNew.TabIndex = 4;
            this.lblNew.Text = "New Service Type:";
            // 
            // cboService_
            // 
            this.cboService_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboService_.FormattingEnabled = true;
            this.cboService_.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.cboService_.Location = new System.Drawing.Point(205, 160);
            this.cboService_.Name = "cboService_";
            this.cboService_.Size = new System.Drawing.Size(393, 31);
            this.cboService_.TabIndex = 8;
            this.cboService_.SelectedIndexChanged += new System.EventHandler(this.cboService__SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(13, 711);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 39);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(398, 711);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(213, 39);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm Requested";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboType_
            // 
            this.cboType_.FormattingEnabled = true;
            this.cboType_.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.cboType_.Location = new System.Drawing.Point(205, 197);
            this.cboType_.Name = "cboType_";
            this.cboType_.Size = new System.Drawing.Size(151, 28);
            this.cboType_.TabIndex = 16;
            this.cboType_.SelectedIndexChanged += new System.EventHandler(this.cboType__SelectedIndexChanged);
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(13, 13);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 29;
            this.dgvService.Size = new System.Drawing.Size(1427, 249);
            this.dgvService.TabIndex = 17;
            // 
            // grpboxDetails
            // 
            this.grpboxDetails.Controls.Add(this.lblService_);
            this.grpboxDetails.Controls.Add(this.txtRequestID_);
            this.grpboxDetails.Controls.Add(this.lblRequestID);
            this.grpboxDetails.Controls.Add(this.lblDetails);
            this.grpboxDetails.Controls.Add(this.cboType_);
            this.grpboxDetails.Controls.Add(this.dtpStart_);
            this.grpboxDetails.Controls.Add(this.lblAmount_);
            this.grpboxDetails.Controls.Add(this.lblDescription_);
            this.grpboxDetails.Controls.Add(this.lblNew);
            this.grpboxDetails.Controls.Add(this.lblNow);
            this.grpboxDetails.Controls.Add(this.cboService_);
            this.grpboxDetails.Controls.Add(this.lblStart_);
            this.grpboxDetails.Controls.Add(this.lblStatus_);
            this.grpboxDetails.Controls.Add(this.lblModel_);
            this.grpboxDetails.Controls.Add(this.textBox6);
            this.grpboxDetails.Controls.Add(this.textBox3);
            this.grpboxDetails.Controls.Add(this.lblAmount);
            this.grpboxDetails.Controls.Add(this.lblDescription);
            this.grpboxDetails.Controls.Add(this.lblStart);
            this.grpboxDetails.Controls.Add(this.lblStatus);
            this.grpboxDetails.Controls.Add(this.lblType);
            this.grpboxDetails.Controls.Add(this.lblModel);
            this.grpboxDetails.Location = new System.Drawing.Point(13, 268);
            this.grpboxDetails.Name = "grpboxDetails";
            this.grpboxDetails.Size = new System.Drawing.Size(692, 430);
            this.grpboxDetails.TabIndex = 18;
            this.grpboxDetails.TabStop = false;
            // 
            // lblService_
            // 
            this.lblService_.AutoSize = true;
            this.lblService_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblService_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblService_.Location = new System.Drawing.Point(205, 124);
            this.lblService_.Name = "lblService_";
            this.lblService_.Size = new System.Drawing.Size(2, 25);
            this.lblService_.TabIndex = 36;
            // 
            // txtRequestID_
            // 
            this.txtRequestID_.Location = new System.Drawing.Point(205, 30);
            this.txtRequestID_.Multiline = true;
            this.txtRequestID_.Name = "txtRequestID_";
            this.txtRequestID_.Size = new System.Drawing.Size(393, 31);
            this.txtRequestID_.TabIndex = 35;
            this.txtRequestID_.TextChanged += new System.EventHandler(this.txtRequestID_TextChanged);
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequestID.Location = new System.Drawing.Point(93, 34);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(106, 24);
            this.lblRequestID.TabIndex = 34;
            this.lblRequestID.Text = "Request id:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetails.Location = new System.Drawing.Point(257, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(149, 27);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "Service Details";
            // 
            // dtpStart_
            // 
            this.dtpStart_.CustomFormat = "yyyy/MM/dd";
            this.dtpStart_.Enabled = false;
            this.dtpStart_.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart_.Location = new System.Drawing.Point(205, 283);
            this.dtpStart_.Name = "dtpStart_";
            this.dtpStart_.Size = new System.Drawing.Size(393, 27);
            this.dtpStart_.TabIndex = 33;
            // 
            // lblAmount_
            // 
            this.lblAmount_.AutoSize = true;
            this.lblAmount_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount_.Location = new System.Drawing.Point(208, 389);
            this.lblAmount_.Name = "lblAmount_";
            this.lblAmount_.Size = new System.Drawing.Size(2, 25);
            this.lblAmount_.TabIndex = 31;
            // 
            // lblDescription_
            // 
            this.lblDescription_.AutoSize = true;
            this.lblDescription_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription_.Location = new System.Drawing.Point(208, 317);
            this.lblDescription_.Name = "lblDescription_";
            this.lblDescription_.Size = new System.Drawing.Size(0, 23);
            this.lblDescription_.TabIndex = 30;
            // 
            // lblStart_
            // 
            this.lblStart_.AutoSize = true;
            this.lblStart_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart_.Location = new System.Drawing.Point(208, 284);
            this.lblStart_.Name = "lblStart_";
            this.lblStart_.Size = new System.Drawing.Size(0, 23);
            this.lblStart_.TabIndex = 28;
            // 
            // lblStatus_
            // 
            this.lblStatus_.AutoSize = true;
            this.lblStatus_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus_.Location = new System.Drawing.Point(208, 238);
            this.lblStatus_.Name = "lblStatus_";
            this.lblStatus_.Size = new System.Drawing.Size(0, 23);
            this.lblStatus_.TabIndex = 27;
            // 
            // lblModel_
            // 
            this.lblModel_.AutoSize = true;
            this.lblModel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModel_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel_.Location = new System.Drawing.Point(205, 78);
            this.lblModel_.Name = "lblModel_";
            this.lblModel_.Size = new System.Drawing.Size(2, 25);
            this.lblModel_.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(205, 316);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(393, 59);
            this.textBox6.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(205, 233);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 40);
            this.textBox3.TabIndex = 20;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(67, 388);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(132, 24);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Total Amount:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(86, 327);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(113, 24);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(98, 283);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(101, 24);
            this.lblStart.TabIndex = 13;
            this.lblStart.Text = "Start Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(132, 241);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(143, 197);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 24);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(129, 77);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(70, 24);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(1394, 722);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(2, 22);
            this.lblID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1286, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer id:";
            // 
            // FrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 762);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpboxDetails);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblServicelist);
            this.Name = "FrmChange";
            this.Text = "Change Requested Service";
            this.Load += new System.EventHandler(this.FrmChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.grpboxDetails.ResumeLayout(false);
            this.grpboxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblServicelist;
        private ListBox listBox1;
        private Label lblNow;
        private Label lblNew;
        private ComboBox cboService_;
        private Button btnBack;
        private Button btnConfirm;
        private ComboBox cboType_;
        private DataGridView dgvService;
        private GroupBox grpboxDetails;
        private DateTimePicker dtpStart_;
        private Label lblAmount_;
        private Label lblDescription_;
        private Label lblStart_;
        private Label lblStatus_;
        private Label lblModel_;
        private TextBox textBox6;
        private TextBox textBox3;
        private Label lblAmount;
        private Label lblDescription;
        private Label lblStart;
        private Label lblStatus;
        private Label lblType;
        private Label lblModel;
        private Label lblDetails;
        private TextBox txtRequestID_;
        private Label lblRequestID;
        private Label lblService_;
        private Label lblID;
        private Label label2;
    }
}