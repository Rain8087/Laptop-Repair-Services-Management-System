using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Laptop_Repair_Services_Management_System
{
    class Public
    {
        private string username;
        private string password;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Password { get => password; set => password = value; }

        public Public(string n, string p)
        {
            username = n;
            password = p;
        }
        public Public(string n)
        {
            username = n;
        }

        public static void viewProfile(Public o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from users where username ='" + o1.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            { 
                o1.password = rd.GetString(2);
            }
            con.Close();
        }

        public string updateProfile(string pass)
        {
            string status;
            con.Open();

            password = pass;

            SqlCommand cmd = new SqlCommand("update users set password='" + password + "'where username ='" + username + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successful.";
            else
                status = "Unable to update.";
            con.Close();

            return status;
        }
    }
}
