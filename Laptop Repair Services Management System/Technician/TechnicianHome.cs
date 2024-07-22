using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class TechnicianHome : Form
    {
        public static string name;
        public TechnicianHome(string n)
        {
            InitializeComponent();
            name = n;
        }
        public TechnicianHome()
        {
            InitializeComponent();
        }

        private void TechnicianHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "Hello, " + name;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewRequest vr = new ViewRequest();
            vr.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangePassword up = new ChangePassword(name);
            up.ShowDialog();
        }
    }
}
