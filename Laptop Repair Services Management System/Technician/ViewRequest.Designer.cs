
namespace Laptop_Repair_Services_Management_System
{
    partial class ViewRequest
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lblRID = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblModel_ = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServiceType_ = new System.Windows.Forms.Label();
            this.lblRDate = new System.Windows.Forms.Label();
            this.lblFDate = new System.Windows.Forms.Label();
            this.lblCDate = new System.Windows.Forms.Label();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.dtpCDate = new System.Windows.Forms.DateTimePicker();
            this.txtTechnician = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCusID = new System.Windows.Forms.Label();
            this.lblCusID_ = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblType_ = new System.Windows.Forms.Label();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 12);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.Size = new System.Drawing.Size(1684, 290);
            this.dgvTable.TabIndex = 0;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(223, 311);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(186, 20);
            this.lblRID.TabIndex = 1;
            this.lblRID.Text = "ID of request to modify: ";
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(415, 308);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(81, 27);
            this.txtRID.TabIndex = 2;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(502, 307);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(94, 29);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(223, 581);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 29);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpFDate
            // 
            this.dtpFDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFDate.Enabled = false;
            this.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFDate.Location = new System.Drawing.Point(757, 387);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(282, 27);
            this.dtpFDate.TabIndex = 5;
            this.dtpFDate.Value = new System.DateTime(2022, 1, 30, 15, 6, 44, 0);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(223, 353);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(65, 20);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model: ";
            // 
            // lblModel_
            // 
            this.lblModel_.AutoSize = true;
            this.lblModel_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModel_.Location = new System.Drawing.Point(294, 353);
            this.lblModel_.Name = "lblModel_";
            this.lblModel_.Size = new System.Drawing.Size(2, 22);
            this.lblModel_.TabIndex = 7;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(944, 353);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(110, 20);
            this.lblServiceType.TabIndex = 8;
            this.lblServiceType.Text = "Service Type: ";
            // 
            // lblServiceType_
            // 
            this.lblServiceType_.AutoSize = true;
            this.lblServiceType_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceType_.Location = new System.Drawing.Point(1060, 353);
            this.lblServiceType_.Name = "lblServiceType_";
            this.lblServiceType_.Size = new System.Drawing.Size(2, 22);
            this.lblServiceType_.TabIndex = 9;
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Location = new System.Drawing.Point(223, 390);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(122, 20);
            this.lblRDate.TabIndex = 10;
            this.lblRDate.Text = "Received Date: ";
            // 
            // lblFDate
            // 
            this.lblFDate.AutoSize = true;
            this.lblFDate.Location = new System.Drawing.Point(655, 390);
            this.lblFDate.Name = "lblFDate";
            this.lblFDate.Size = new System.Drawing.Size(96, 20);
            this.lblFDate.TabIndex = 12;
            this.lblFDate.Text = "Finish Date: ";
            // 
            // lblCDate
            // 
            this.lblCDate.AutoSize = true;
            this.lblCDate.Location = new System.Drawing.Point(1055, 390);
            this.lblCDate.Name = "lblCDate";
            this.lblCDate.Size = new System.Drawing.Size(129, 20);
            this.lblCDate.TabIndex = 13;
            this.lblCDate.Text = "Collection Date: ";
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Location = new System.Drawing.Point(251, 428);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(94, 20);
            this.lblTechnician.TabIndex = 14;
            this.lblTechnician.Text = "Technician: ";
            // 
            // dtpCDate
            // 
            this.dtpCDate.CustomFormat = "yyyy/MM/dd";
            this.dtpCDate.Enabled = false;
            this.dtpCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCDate.Location = new System.Drawing.Point(1190, 387);
            this.dtpCDate.Name = "dtpCDate";
            this.dtpCDate.Size = new System.Drawing.Size(282, 27);
            this.dtpCDate.TabIndex = 15;
            this.dtpCDate.Value = new System.DateTime(2022, 2, 9, 21, 35, 13, 0);
            // 
            // txtTechnician
            // 
            this.txtTechnician.Location = new System.Drawing.Point(351, 425);
            this.txtTechnician.Name = "txtTechnician";
            this.txtTechnician.Size = new System.Drawing.Size(629, 27);
            this.txtTechnician.TabIndex = 16;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ongoing",
            "Done"});
            this.cboStatus.Location = new System.Drawing.Point(1321, 425);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(151, 28);
            this.cboStatus.TabIndex = 17;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1253, 428);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status: ";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(351, 459);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(1121, 116);
            this.rtxtDescription.TabIndex = 19;
            this.rtxtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(244, 462);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 20);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1378, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(849, 311);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(107, 20);
            this.lblCusID.TabIndex = 22;
            this.lblCusID.Text = "Customer ID: ";
            // 
            // lblCusID_
            // 
            this.lblCusID_.AutoSize = true;
            this.lblCusID_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCusID_.Location = new System.Drawing.Point(962, 311);
            this.lblCusID_.Name = "lblCusID_";
            this.lblCusID_.Size = new System.Drawing.Size(2, 22);
            this.lblCusID_.TabIndex = 23;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(1233, 311);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 20);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Type: ";
            // 
            // lblType_
            // 
            this.lblType_.AutoSize = true;
            this.lblType_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType_.Location = new System.Drawing.Point(1292, 311);
            this.lblType_.Name = "lblType_";
            this.lblType_.Size = new System.Drawing.Size(2, 22);
            this.lblType_.TabIndex = 25;
            // 
            // dtpRDate
            // 
            this.dtpRDate.CustomFormat = "yyyy/MM/dd";
            this.dtpRDate.Enabled = false;
            this.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRDate.Location = new System.Drawing.Point(351, 387);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(282, 27);
            this.dtpRDate.TabIndex = 26;
            // 
            // ViewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 622);
            this.Controls.Add(this.dtpRDate);
            this.Controls.Add(this.lblType_);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCusID_);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtTechnician);
            this.Controls.Add(this.dtpCDate);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.lblCDate);
            this.Controls.Add(this.lblFDate);
            this.Controls.Add(this.lblRDate);
            this.Controls.Add(this.lblServiceType_);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblModel_);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.dtpFDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.dgvTable);
            this.Name = "ViewRequest";
            this.Text = "ViewRequest";
            this.Load += new System.EventHandler(this.ViewRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpFDate;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblModel_;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServiceType_;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label lblFDate;
        private System.Windows.Forms.Label lblCDate;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.DateTimePicker dtpCDate;
        private System.Windows.Forms.TextBox txtTechnician;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label lblCusID_;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblType_;
        private System.Windows.Forms.DateTimePicker dtpRDate;
    }
}