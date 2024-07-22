using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class AdminHome : Form
    {
        public static string name;
        public AdminHome(string n)
        {
            InitializeComponent();
            name = n;
        }
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "Hello, " + name;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStaff r = new RegisterStaff();
            r.ShowDialog();
        }

        private void btnViewService_Click(object sender, EventArgs e)
        {
            ServiceReport s = new ServiceReport();
            s.ShowDialog();
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {
            TotalIncome t = new TotalIncome();
            t.ShowDialog();
        }
    }
}
