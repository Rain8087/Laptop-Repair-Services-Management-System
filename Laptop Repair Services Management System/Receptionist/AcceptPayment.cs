using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Receptionist
{
    public partial class AcceptPayment : Form
    {
        public AcceptPayment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtID.Text);
                Receptionist obj1 = new Receptionist(txtID.Text);
                dataGridView1.DataSource = obj1.search();
            }
            catch
            {
                MessageBox.Show("Please enter number.");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtRId.Text == "")
            {

            }
            else
            {
                try
                {
                    int.Parse(txtRId.Text);
                    Receptionist obj2 = new Receptionist(txtRId.Text, txtID.Text);
                    Receptionist obj1 = new Receptionist(txtID.Text);
                    string message = obj2.Payment(txtRId.Text, txtID.Text);
                    MessageBox.Show(message);
                    if (message == "Payment Done")
                    {
                        Receipt r = new Receipt(txtRId.Text);
                        r.ShowDialog();
                        dataGridView1.DataSource = obj1.search();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid request id");
                    }
                }
                catch
                {

                }
            }
        }
    }
}
