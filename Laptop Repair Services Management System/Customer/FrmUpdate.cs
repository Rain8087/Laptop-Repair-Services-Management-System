using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class FrmUpdate : Form
    {
        public static string Id;
        public FrmUpdate()
        {
            InitializeComponent();
        }
        public FrmUpdate(string i)
        {
            InitializeComponent();
            Id = i;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            Customer obj1 = new Customer(Id);
            Customer.PersonalProfile(obj1);
            txtUsername.Text = obj1.Name;
            txtEmail.Text = obj1.Email;
            txtPhone.Text = obj1.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer obj2 = new Customer(Id);
            if (txtNewEmail.Text == "" && txtNewPhone.Text == "")
            {
                MessageBox.Show("Please enter new email or new phone number.");
            }
            else if (txtNewEmail.Text == txtEmail.Text || txtNewPhone.Text == txtPhone.Text)
            {
                MessageBox.Show("New email or phone number is same as original one.");
            }
            else if (txtNewEmail.Text != txtEmail.Text && txtNewPhone.Text != txtPhone.Text)
            {
                MessageBox.Show(obj2.updateProfile(txtNewEmail.Text, txtNewPhone.Text));
                this.Close();
            }
            else if (txtNewEmail.Text != txtEmail.Text && txtNewPhone.Text == "")
            {
                MessageBox.Show(obj2.updateProfile(txtNewEmail.Text, txtPhone.Text));
                this.Close();
            }
            else if (txtNewEmail.Text == "" && txtNewPhone.Text != txtPhone.Text)
            {
                MessageBox.Show(obj2.updateProfile(txtEmail.Text, txtNewPhone.Text));
                this.Close();
            }
        }
    }
}
