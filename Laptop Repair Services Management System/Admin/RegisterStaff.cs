using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class RegisterStaff : Form
    {
        public RegisterStaff()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else if (cmbRole.Text == "")
            {
                MessageBox.Show("Please choose user role");
            }
            else
            {
                Admin obj1 = new Admin(txtUsername.Text, txtPassword.Text, cmbRole.Text);
                MessageBox.Show(obj1.addUser());
            }
        }
    }
}
