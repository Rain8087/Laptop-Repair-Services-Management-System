using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Receptionist
{
    class Receptionist
    {
        private string Username;
        private string RePassword;
        private string Name;
        private string Phone;
        private string Email;
        private string CusName;
        private string CusID;
        private string Model;
        private string ServiceType;
        private string RDate;
        private string Type;
        private string Fee;
        private string Status;
        private string RequestID;
        private string TechnicianName;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string CusID1 { get => CusID; set => CusID = value; }
        public string Model1 { get => Model; set => Model = value; }
        public string ServiceType1 { get => ServiceType; set => ServiceType = value; }
        public string RDate1 { get => RDate; set => RDate = value; }
        public string Type1 { get => Type; set => Type = value; }
        public string CusName1 { get => CusName; set => CusName = value; }
        public string TechnicianName1 { get => TechnicianName; set => TechnicianName = value; }
        public string Fee1 { get => Fee; set => Fee = value; }

        public Receptionist(string id)
        {
            CusID = id;
        }

        public Receptionist(string id, string n, string m, string s, string r, string t, string f)
        {
            CusID = id;
            Name = n;
            Model = m;
            ServiceType = s;
            RDate = r;
            Type = t;
            Fee = f;
        }

        public Receptionist(string id, string s)
        {
            CusID = id;
            Status = s;
        }

        public string Add(string u, string rp, string n, string ph, string e)
        {
            string Status;
            con.Open();

            Username = u;
            RePassword = rp;
            Name = n;
            Phone = ph;
            Email = e;

            SqlCommand cmdc = new SqlCommand("Select count(*) from customers", con);
            int cusid = Convert.ToInt32(cmdc.ExecuteScalar().ToString())+1;
            SqlCommand cmd = new SqlCommand("Select count(*) from users where username='" + Username + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count > 0)
                Status = "Username is in use.";
            else
            {
                SqlCommand cmd3 = new SqlCommand("Insert into users(username, password, role, [Customer ID]) values(@Username, @Password, 'customer',"+cusid+")", con);
                SqlCommand cmd4 = new SqlCommand("Insert into customers(Name, [Phone Number], Email) values(@Name, @Phone, @Email)", con);
                cmd3.Parameters.AddWithValue("@Username", Username);
                cmd3.Parameters.AddWithValue("@Password", RePassword);
                cmd4.Parameters.AddWithValue("@Name", Name);
                cmd4.Parameters.AddWithValue("@Phone", Phone);
                cmd4.Parameters.AddWithValue("@Email", Email);
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();

                Status = "Registration Successful";

            }
            con.Close();
            return Status;
        }

        public static void choose_cus(Receptionist o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *From customers where id = '" + o1.CusID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.CusName = rd.GetValue(1).ToString();
            }
            con.Close();
        }

        public string addRequest()
        {
            string Status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Request([Customer ID], [Customer Name], Model, [Service Type], [Received Date], Status, Type, [Service Fee]) values(@CusID, @Name, @Model, @ServiceType, @RDate, 'Pending', @Type, @Fee)", con);

            cmd.Parameters.AddWithValue("@CusID", CusID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@ServiceType", ServiceType);
            cmd.Parameters.AddWithValue("RDate", RDate);
            cmd.Parameters.AddWithValue("@Type", Type);
            cmd.Parameters.AddWithValue("@Fee", Fee);
            cmd.ExecuteNonQuery();
            Status = "Request added.";
            con.Close();
            return Status;
        }

        public BindingSource search()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *From Request where [Customer ID] = '" + CusID + "' And Status = 'Done'", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dbdataset;
            con.Close();
            return bSource;
        }

        public string Payment(string id, string Cusid)
        {
            string Status;
            string s = "Paid";
            con.Open();

            SqlCommand cmd = new SqlCommand("Update Request set Status = '" + s + "'Where id = '" + id + "' And [Customer ID] = '" + Cusid + "' And Status = 'Done'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                Status = "Payment Done";
            else
                Status = "Payment Fail";
            con.Close();
            return Status;
        }

        public static void Getreceipt(Receptionist o2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from request where id ='" + o2.CusID + "'", con);
            SqlDataReader rd1 = cmd.ExecuteReader();
            while (rd1.Read())
            {
                o2.CusName = rd1.GetValue(2).ToString();
                o2.ServiceType = rd1.GetString(4);
                o2.TechnicianName = rd1.GetString(8);
                o2.Type = rd1.GetString(11);
                o2.Fee = rd1.GetValue(12).ToString();
            }
            con.Close();
        }
    }
}
