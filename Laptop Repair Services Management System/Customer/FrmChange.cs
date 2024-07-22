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
    public partial class FrmChange : Form
    {
        public static string name;
        public FrmChange()
        {
            InitializeComponent();
        }
        public FrmChange(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadData()
        {
            try
            {
                int.Parse(txtRequestID_.Text);
                Customer obj1 = new Customer(lblID.Text, txtRequestID_.Text);
                //calling static method require className.method(..)
                //pass object obj1 to method viewProfile
                Customer.loadDetail(obj1);
                lblModel_.Text = obj1.Model;
                lblService_.Text = obj1.ServiceType;
                dtpStart_.Text = obj1.ReceivedDate;
                lblDescription_.Text = obj1.Description1;
                lblStatus_.Text = obj1.Status;
                cboType_.Text = obj1.Type;
                lblAmount_.Text = "RM " + obj1.Fee;
            }
            catch
            {
                MessageBox.Show("Please enter number");
                txtRequestID_.Text = string.Empty;
            }
        }

        void CalculateFee()
        {
            if (cboService_.Text == "Remove virus, malware or spyware" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "50";
            }
            else if (cboService_.Text == "Remove virus, malware or spyware" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "80";
            }
            else if (cboService_.Text == "Troubleshot and fix computer running slow" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "60";
            }
            else if (cboService_.Text == "Troubleshot and fix computer running slow" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "90";
            }
            else if (cboService_.Text == "Laptop screen replacement" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "380";
            }
            else if (cboService_.Text == "Laptop screen replacement" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "430";
            }
            else if (cboService_.Text == "Laptop keyboard replacement" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "160";
            }
            else if (cboService_.Text == "Laptop keyboard replacement" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "200";
            }
            else if (cboService_.Text == "Laptop battery replacement" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "180";
            }
            else if (cboService_.Text == "Laptop battery replacement" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "210";
            }
            else if (cboService_.Text == "Operating System Format and Installation" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "100";
            }
            else if (cboService_.Text == "Operating System Format and Installation" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "150";
            }
            else if (cboService_.Text == "Data backup and recovery" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "80";
            }
            else if (cboService_.Text == "Data backup and recovery" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "130";
            }
            else if (cboService_.Text == "Internet connectivity issues" && cboType_.Text == "Normal")
            {
                lblAmount_.Text = "70";
            }
            else if (cboService_.Text == "Internet connectivity issues" && cboType_.Text == "Urgent")
            {
                lblAmount_.Text = "100";
            }
        }

        private void FrmChange_Load(object sender, EventArgs e)
        {
            Customer obj = new Customer(name);
            Customer.search(obj);
            //calling static method require className.method(..)
            //pass object obj1 to method viewProfile
            lblID.Text = obj.CustomerID;
            dgvService.DataSource = Customer.LoadTable(lblID.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtRequestID_.Text == "")
                MessageBox.Show("Please enter request id to begin.");
            else if (cboService_.Text == "" || cboType_.Text == "")
            {
                MessageBox.Show("Please choose new service type or type.");
            }
            else
            {
                Customer obj1 = new Customer(lblID.Text);
                MessageBox.Show(obj1.ChangeService(lblID.Text, cboService_.Text, cboType_.Text, Convert.ToInt32(lblAmount_.Text)));
                dgvService.DataSource = Customer.LoadTable(lblID.Text);
            }
        }

        private void txtRequestID_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboService__SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }

        private void cboType__SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateFee();
        }
    }
}
