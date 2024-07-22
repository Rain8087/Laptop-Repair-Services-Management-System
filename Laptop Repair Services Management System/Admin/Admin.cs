using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    class Admin
    {
        private string UserName;
        private string Password;
        private string Role;
        private string Year;
        private string Month;
        private string income;
        private string Remove;
        private string Trobleshoot;
        private string Screen;
        private string Keyboard;
        private string Battery;
        private string OperatingSystem;
        private string DataBackup;
        private string Internet;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Income { get => income; set => income = value; }
        public string Remove1 { get => Remove; set => Remove = value; }
        public string Trobleshoot1 { get => Trobleshoot; set => Trobleshoot = value; }
        public string Screen1 { get => Screen; set => Screen = value; }
        public string Keyboard1 { get => Keyboard; set => Keyboard = value; }
        public string Battery1 { get => Battery; set => Battery = value; }
        public string OperatingSystem1 { get => OperatingSystem; set => OperatingSystem = value; }
        public string DataBackup1 { get => DataBackup; set => DataBackup = value; }
        public string Internet1 { get => Internet; set => Internet = value; }

        public Admin(string n, string p, string r)
        {
            UserName = n;
            Password = p;
            Role = r;
        }

        public Admin(string y, string m)
        {
            Year = y;
            Month = m;
        }

        public string addUser()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) From users where username='" + UserName + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count > 0)
                status = "Username have been used, please choose another username.";
            else
            {
                SqlCommand cmd2 = new SqlCommand("Insert into users(username, password, role) values(@name, @pass, @role)", con);
                cmd2.Parameters.AddWithValue("@name", UserName);
                cmd2.Parameters.AddWithValue("@pass", Password);
                cmd2.Parameters.AddWithValue("@role", Role);
                cmd2.ExecuteNonQuery();
                status = "Registration Successful.";
            }
            con.Close();
            return status;
        }

        public static void ViewSReport(Admin o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Remove virus, malware or spyware' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.Remove = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Troubleshot and fix computer running slow' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.Trobleshoot = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Laptop screen replacement' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.Screen = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd3 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Laptop keyboard replacement' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.Keyboard = cmd3.ExecuteScalar().ToString();
            SqlCommand cmd4 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Laptop battery replacement' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.Battery = cmd4.ExecuteScalar().ToString();
            SqlCommand cmd5 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Operating System Format and Installation' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.OperatingSystem = cmd5.ExecuteScalar().ToString();
            SqlCommand cmd6 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Data backup and recovery' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.DataBackup = cmd6.ExecuteScalar().ToString();
            SqlCommand cmd7 = new SqlCommand("Select count([Service Type]) From Request where ([Service Type]) = 'Internet connectivity issues' And MONTH([Received Date]) = '" + o1.Month + "'And YEAR([Received Date]) = '" + o1.Year + "'", con);
            o1.Internet = cmd7.ExecuteScalar().ToString();
            con.Close();
        }

        public static void ViewIncome(Admin o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Sum([Service Fee]) From Request where MONTH([Collection Date]) = '" + o1.Month + "'And YEAR([Collection Date]) = '" + o1.Year + "' And Status = 'Paid'", con);
            o1.income = cmd.ExecuteScalar().ToString();
            con.Close();
        }
    }
}
