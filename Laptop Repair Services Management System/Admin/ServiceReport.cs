using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class ServiceReport : Form
    {
        public ServiceReport()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Admin obj1 = new Admin(dtpY.Text, dtpM.Text);
            Admin.ViewSReport(obj1);
            lblRemove.Text = obj1.Remove1;
            lblTrobleshot.Text = obj1.Trobleshoot1;
            lblScreen.Text = obj1.Screen1;
            lblKeyboard.Text = obj1.Keyboard1;
            lblBattery.Text = obj1.Battery1;
            lblOperatingSystem.Text = obj1.OperatingSystem1;
            lblDataBackup.Text = obj1.DataBackup1;
            lblInternet.Text = obj1.Internet1;
        }
    }
}
