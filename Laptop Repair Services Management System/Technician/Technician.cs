using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Laptop_Repair_Services_Management_System.Technician
{
    class Technician
    {
        private string RequestID;
        private string CustomerID;
        private string Model;
        private string ServiceType;
        private string Received;
        private string Fin;
        private string Collect;
        private string Techniciann;
        private string Description;
        private string Status;
        private string Type;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public string Model1 { get => Model; set => Model = value; }
        public string ServiceType1 { get => ServiceType; set => ServiceType = value; }
        public string Received1 { get => Received; set => Received = value; }
        public string Fin1 { get => Fin; set => Fin = value; }
        public string Collect1 { get => Collect; set => Collect = value; }
        public string Techniciann1 { get => Techniciann; set => Techniciann = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Type1 { get => Type; set => Type = value; }

        public Technician(string id)
        {
            RequestID = id;
        }

        public static BindingSource viewTable()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *From Request", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dbdataset;
            con.Close();
            return bSource;
        }

        public static void Lock_table(Technician o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *From Request where id = '" + o1.RequestID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.CustomerID = rd.GetValue(1).ToString();
                o1.Model = rd.GetString(3);
                o1.ServiceType = rd.GetString(4);
                o1.Received = rd.GetValue(5).ToString();
                o1.Fin = rd.GetValue(6).ToString();
                o1.Collect = rd.GetValue(7).ToString();
                o1.Techniciann = rd.GetValue(8).ToString();
                o1.Description = rd.GetValue(9).ToString();
                o1.Status = rd.GetString(10);
                o1.Type = rd.GetString(11);
            }
            con.Close();
        }

        public string Update(string fi, string co, string te, string de, string st)
        {
            string Upstat;
            con.Open();

            Fin = fi;
            Collect = co;
            Techniciann = te;
            Description = de;
            Status = st;

            SqlCommand cmd = new SqlCommand("update Request set [Finish Date] ='" + Fin + "',[Collection Date] ='" + Collect + "',Technician ='" + Techniciann + "',Description ='" + Description + "',Status = '" + Status + "'where id ='" + RequestID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                Upstat = "Update Successful.";
            else
                Upstat = "Unable to Update.";
            con.Close();
            return Upstat;
        }
    }
}
