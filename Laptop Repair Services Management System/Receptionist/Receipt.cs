using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Receptionist
{
    public partial class Receipt : Form
    {
        public static string RequestID;

        public Receipt(string rid)
        {
            InitializeComponent();
            RequestID = rid;
        }

        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(RequestID);
            Receptionist.Getreceipt(obj1);
            lblName.Text = obj1.CusName1;
            lblService.Text = obj1.ServiceType1;
            lblTechnician.Text = obj1.TechnicianName1;
            lblType.Text = obj1.Type1;
            lblPrice.Text = obj1.Fee1;
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(lblPrice.Text);
                int receive = Convert.ToInt32(txtPaid.Text);
                lblChange.Text = (receive - price).ToString();
            }
            catch
            {
                MessageBox.Show("Please number only");
            }
        }
    }
}
