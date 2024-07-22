using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Receptionist
{
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(txtName.Text);
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtRePassword.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill in all available space");
            }
            else if (txtPassword.Text == txtRePassword.Text)
            {
                MessageBox.Show(obj1.Add(txtUsername.Text, txtRePassword.Text, txtName.Text, txtPhone.Text, txtEmail.Text));
            }
            else
            {
                MessageBox.Show("Both password do not match.");
            }
        }
    }
}
