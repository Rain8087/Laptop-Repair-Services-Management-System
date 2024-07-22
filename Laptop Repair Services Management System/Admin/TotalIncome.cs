using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class TotalIncome : Form
    {
        public TotalIncome()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Admin obj1 = new Admin(dtpY.Text, dtpM.Text);
            Admin.ViewIncome(obj1);
            lblIncome.Text = obj1.Income;
        }
    }
}
