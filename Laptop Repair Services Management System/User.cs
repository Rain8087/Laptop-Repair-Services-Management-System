using Laptop_Repair_Services_Management_System.Receptionist;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Laptop_Repair_Services_Management_System
{
    internal class User
    {
        private string username;
        private string password;

        public User(string u, string p)
        {
            username = u;
            password = p;
        }

        public User(string n)
        {
            username = n;
        }

        public string login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username='" + username + "' and password ='" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username ='" + username + "' and password ='" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "technician")
                {
                    TechnicianHome t = new TechnicianHome(un);
                    t.ShowDialog();
                }
                else if (userRole == "admin")
                {
                    AdminHome a = new AdminHome(un);
                    a.ShowDialog();
                }
                else if (userRole == "receptionist")
                {
                    ReceptionistHome r = new ReceptionistHome(un);
                    r.ShowDialog();
                }
                else if (userRole == "customer")
                {
                    FrmCustomer c = new FrmCustomer(un);
                    c.ShowDialog();
                }
            }
            else
                status = "Incorrect username/password";
            con.Close();

            return status;
        }
    }
}
