
namespace Laptop_Repair_Services_Management_System
{
    partial class AdminHome
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnViewService = new System.Windows.Forms.Button();
            this.btnViewIncome = new System.Windows.Forms.Button();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(123, 87);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(172, 29);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register New User";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnViewService
            // 
            this.btnViewService.Location = new System.Drawing.Point(123, 138);
            this.btnViewService.Name = "btnViewService";
            this.btnViewService.Size = new System.Drawing.Size(172, 29);
            this.btnViewService.TabIndex = 1;
            this.btnViewService.Text = "View Service Report";
            this.btnViewService.UseVisualStyleBackColor = true;
            this.btnViewService.Click += new System.EventHandler(this.btnViewService_Click);
            // 
            // btnViewIncome
            // 
            this.btnViewIncome.Location = new System.Drawing.Point(123, 189);
            this.btnViewIncome.Name = "btnViewIncome";
            this.btnViewIncome.Size = new System.Drawing.Size(172, 29);
            this.btnViewIncome.TabIndex = 2;
            this.btnViewIncome.Text = "View Total Income";
            this.btnViewIncome.UseVisualStyleBackColor = true;
            this.btnViewIncome.Click += new System.EventHandler(this.btnViewIncome_Click);
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdentity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentity.Location = new System.Drawing.Point(12, 9);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(2, 29);
            this.lblIdentity.TabIndex = 4;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 248);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.btnViewIncome);
            this.Controls.Add(this.btnViewService);
            this.Controls.Add(this.btnRegister);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnViewService;
        private System.Windows.Forms.Button btnViewIncome;
        private System.Windows.Forms.Label lblIdentity;
    }
}