using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class ChangePassword : Form
    {
        public static string name;
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void UpdateProfile_Staff_Load(object sender, EventArgs e)
        {
            Public obj1 = new Public(name);
            Public.viewProfile(obj1);
            txtPassword.Text = obj1.Password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                MessageBox.Show("Please enter a valid password");
            else
            {
                Public obj1 = new Public(name);
                MessageBox.Show(obj1.updateProfile(txtPassword.Text));
                this.Close();
            }
        }

    }
}
