using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System
{
    internal class Customer
    {
        private string name;
        private string customerID;
        private string model;
        private string serviceType;
        private string receivedDate;
        private string finishDate;
        private string collectionDate;
        private string Technician;
        private string Description;
        private string status;
        private string type;
        private string fee;
        private string email;
        private string phone;
        private string rID;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Name { get => name; set => name = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string Model { get => model; set => model = value; }
        public string ServiceType { get => serviceType; set => serviceType = value; }
        public string ReceivedDate { get => receivedDate; set => receivedDate = value; }
        public string FinishDate { get => finishDate; set => finishDate = value; }
        public string CollectionDate { get => collectionDate; set => collectionDate = value; }
        public string Technician1 { get => Technician; set => Technician = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }
        public string Fee { get => fee; set => fee = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string RID { get => rID; set => rID = value; }

        public Customer(string n)
        {
            name = n;
            customerID = n;
        }

        public Customer(string CID, string ID)
        {
            CustomerID = CID;
            rID = ID;
        }

        public static void search(Customer o)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select [Customer ID] from users where username ='" + o.name + "'", con);
            SqlDataReader rd1 = cmd.ExecuteReader();
            while (rd1.Read())
            {
                o.customerID = rd1.GetValue(0).ToString();
            }
            con.Close();
        }

        public static void loadDetail(Customer o1) 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Request where [Customer ID] ='" + o1.CustomerID + "' And Status = 'Pending' And id ='" + o1.rID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.Model = rd.GetString(3);
                o1.serviceType = rd.GetString(4);
                o1.receivedDate = rd.GetValue(5).ToString();
                o1.Description1 = rd.GetValue(9).ToString();
                o1.status = rd.GetString(10);
                o1.type = rd.GetString(11);
                o1.fee = rd.GetValue(12).ToString();
            }
            con.Close();
        }
        public static void PersonalProfile(Customer o2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customers where id ='" + o2.customerID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o2.Name = rd.GetString(1);
                o2.Phone = rd.GetString(2);
                o2.Email = rd.GetString(3);
            }
            con.Close();
        }
        public string updateProfile(string em, string num)
        {
            string status;
            con.Open();

            email = em;
            phone = num;
            SqlCommand cmd = new SqlCommand("update customers set Email ='" +email+ "',[Phone Number]='" + phone+ "'where id ='" + customerID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";

            con.Close();

            return status;
        }
        public string ChangeService(string id, string st, string t,int f)
        {
            string status;
            con.Open();

            RID = id;
            serviceType = st;
            type = t;
            fee = f.ToString();
            SqlCommand cmd = new SqlCommand("update Request set [Service Type] ='" + serviceType + "',type='" + type +"', [Service Fee] ='"+fee+ "'where id ='" + RID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Change Successfully.";
            else
                status = "Unable to change.";

            con.Close();

            return status;
        }

        public  static BindingSource LoadTable(string id)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select *From Request where [Customer ID] ='" + id + "'And Status = 'Pending'", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dbdataset;

            con.Close();
            return bSource;
        }
    }
}
