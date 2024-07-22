using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    partial class FrmCustomer
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblUsername_ = new System.Windows.Forms.Label();
            this.lblID_ = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.Location = new System.Drawing.Point(146, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(270, 36);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Interface";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(12, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblI.Location = new System.Drawing.Point(76, 87);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(32, 23);
            this.lblI.TabIndex = 2;
            this.lblI.Text = "ID:";
            // 
            // lblUsername_
            // 
            this.lblUsername_.AutoSize = true;
            this.lblUsername_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername_.Location = new System.Drawing.Point(114, 60);
            this.lblUsername_.Name = "lblUsername_";
            this.lblUsername_.Size = new System.Drawing.Size(0, 23);
            this.lblUsername_.TabIndex = 3;
            // 
            // lblID_
            // 
            this.lblID_.AutoSize = true;
            this.lblID_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID_.Location = new System.Drawing.Point(114, 87);
            this.lblID_.Name = "lblID_";
            this.lblID_.Size = new System.Drawing.Size(0, 23);
            this.lblID_.TabIndex = 4;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePass.Location = new System.Drawing.Point(243, 62);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(301, 28);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(12, 131);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(243, 126);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(301, 29);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "View/Change Requested Service";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(114, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 13;
            // 
            // btnChangeData
            // 
            this.btnChangeData.Location = new System.Drawing.Point(243, 91);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(301, 29);
            this.btnChangeData.TabIndex = 15;
            this.btnChangeData.Text = "Change Personal Data";
            this.btnChangeData.UseVisualStyleBackColor = true;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 178);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblID_);
            this.Controls.Add(this.lblUsername_);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCustomer);
            this.Name = "FrmCustomer";
            this.Text = "Service Details";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCustomer;
        private Label lblUsername;
        private Label lblI;
        private Label lblUsername_;
        private Label lblID_;
        private Button btnChangePass;
        private Button btnLogout;
        private Button btnChange;
        private Label lblID;
        private Button btnChangeData;
    }
}