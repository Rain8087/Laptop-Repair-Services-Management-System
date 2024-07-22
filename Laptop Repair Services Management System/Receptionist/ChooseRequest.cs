using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Receptionist
{
    public partial class ChooseRequest : Form
    {
        public ChooseRequest()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(txtID.Text);
            Receptionist.choose_cus(obj1);
            lblName.Text = obj1.CusName1;
        }

        public void CalFee()
        {
            if (cmbServiceType.Text == "Remove virus, malware or spyware" && cmbType.Text == "Normal")
                lblServiceFee.Text = "50";
            else if (cmbServiceType.Text == "Remove virus, malware or spyware" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "80";
            else if (cmbServiceType.Text == "Troubleshot and fix computer running slow" && cmbType.Text == "Normal")
                lblServiceFee.Text = "60";
            else if (cmbServiceType.Text == "Troubleshot and fix computer running slow" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "90";
            else if (cmbServiceType.Text == "Laptop screen replacement" && cmbType.Text == "Normal")
                lblServiceFee.Text = "380";
            else if (cmbServiceType.Text == "Laptop screen replacement" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "430";
            else if (cmbServiceType.Text == "Laptop keyboard replacement" && cmbType.Text == "Normal")
                lblServiceFee.Text = "160";
            else if (cmbServiceType.Text == "Laptop keyboard replacement" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "200";
            else if (cmbServiceType.Text == "Laptop battery replacement" && cmbType.Text == "Normal")
                lblServiceFee.Text = "180";
            else if (cmbServiceType.Text == "Laptop battery replacement" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "210";
            else if (cmbServiceType.Text == "Operating System Format and Installation" && cmbType.Text == "Normal")
                lblServiceFee.Text = "100";
            else if (cmbServiceType.Text == "Operating System Format and Installation" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "150";
            else if (cmbServiceType.Text == "Data backup and recovery" && cmbType.Text == "Normal")
                lblServiceFee.Text = "80";
            else if (cmbServiceType.Text == "Data backup and recovery" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "130";
            else if (cmbServiceType.Text == "Internet connectivity issues" && cmbType.Text == "Normal")
                lblServiceFee.Text = "70";
            else if (cmbServiceType.Text == "Internet connectivity issues" && cmbType.Text == "Urgent")
                lblServiceFee.Text = "100";
            else
                lblServiceFee.Text = "";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalFee();
        }

        private void cmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalFee();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter customer ID");
            }
            else if (txtModel.Text == "" || cmbServiceType.Text == "" || cmbType.Text == "")
                MessageBox.Show("Please make sure everything is filled.");
            else
            {
                Receptionist obj = new Receptionist(txtID.Text, lblName.Text, txtModel.Text, cmbServiceType.Text, dtpReceived.Text, cmbType.Text, lblServiceFee.Text);
                MessageBox.Show(obj.addRequest());
                this.Close();
            }
        }
    }
}
