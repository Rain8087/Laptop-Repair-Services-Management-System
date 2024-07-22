using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    public partial class ViewRequest : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycs"].ToString());
        public ViewRequest()
        {
            InitializeComponent();
        }

        void Load_table()
        {
            dgvTable.DataSource = Technician.Technician.viewTable();
        }


        private void ViewRequest_Load(object sender, EventArgs e)
        {
            Load_table();
            dtpCDate.CustomFormat = " ";
            dtpFDate.CustomFormat = " ";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_table();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Technician.Technician obj1 = new Technician.Technician(txtRID.Text);
            Technician.Technician.Lock_table(obj1);
            lblCusID_.Text = obj1.CustomerID1;
            lblModel_.Text = obj1.Model1;
            lblServiceType_.Text = obj1.ServiceType1;
            dtpRDate.Text = obj1.Received1;
            dtpFDate.Text = obj1.Fin1;
            dtpCDate.Text = obj1.Collect1;
            txtTechnician.Text = obj1.Techniciann1;
            rtxtDescription.Text = obj1.Description1;
            cboStatus.Text = obj1.Status1;
            lblType_.Text = obj1.Type1;
            if (cboStatus.Text == "Paid")
            {
                dtpFDate.Enabled = false;
                dtpCDate.Enabled = false;
                txtTechnician.Enabled = false;
                cboStatus.Enabled = false;
                rtxtDescription.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                dtpFDate.Enabled = true;
                dtpCDate.Enabled = true;
                txtTechnician.Enabled = true;
                cboStatus.Enabled = true;
                rtxtDescription.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRID.Text == "")
            {
                MessageBox.Show("Please enter request id to modify.");
            }
            else if (txtTechnician.Text == "")
            {
                MessageBox.Show("Please key in your name.");
            }
            else
            {
                Technician.Technician obj1 = new Technician.Technician(txtRID.Text);
                MessageBox.Show(obj1.Update(dtpFDate.Text, dtpCDate.Text, txtTechnician.Text, rtxtDescription.Text, cboStatus.Text));
                Load_table();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.Text == "Ongoing")
            {
                dtpFDate.Enabled = false;
                dtpCDate.Enabled = false;
                dtpCDate.CustomFormat = " ";
                dtpFDate.CustomFormat = " ";
            }
            else if (cboStatus.Text == "Done")
            {
                dtpCDate.Enabled = true;
                dtpFDate.Enabled = true;
                dtpCDate.CustomFormat = "yyyy/MM/dd";
                dtpFDate.CustomFormat = "yyyy/MM/dd";
            }
            else if (cboStatus.Text == "Paid")
            {
                dtpCDate.Enabled = true;
                dtpFDate.Enabled = true;
                dtpCDate.CustomFormat = "yyyy/MM/dd";
                dtpFDate.CustomFormat = "yyyy/MM/dd";
            }
        }
    }
}
