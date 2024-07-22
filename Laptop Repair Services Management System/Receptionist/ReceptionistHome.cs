using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Receptionist
{
    public partial class ReceptionistHome : Form
    {
        public static string name;
        public ReceptionistHome(string n)
        {
            InitializeComponent();
            name = n;
        }
        public ReceptionistHome()
        {
            InitializeComponent();
        }

        private void ReceptionistHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = name;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterCustomer r = new RegisterCustomer();
            r.ShowDialog();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChooseRequest c = new ChooseRequest();
            c.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            AcceptPayment a = new AcceptPayment();
            a.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangePassword up = new ChangePassword(name);
            up.ShowDialog();
        }
    }
}
