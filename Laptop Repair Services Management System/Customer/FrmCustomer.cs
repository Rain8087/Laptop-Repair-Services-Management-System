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
    public partial class FrmCustomer : Form
    {
        public static string name;
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public FrmCustomer(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword up = new ChangePassword(name);
            up.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            lblUsername_.Text = name;
            Customer obj = new Customer(name);
            Customer.search(obj);
            lblID.Text = obj.CustomerID;
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            FrmUpdate up = new FrmUpdate(lblID.Text);
            up.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FrmChange f3 = new FrmChange(lblID.Text);
            f3.ShowDialog();
        }
    }
}

