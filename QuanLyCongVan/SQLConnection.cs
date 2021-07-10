using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCongVan
{
    public class SQLConnection
    {
        public static SqlConnection cnn = new SqlConnection("Data Source = LAPTOPNEWVN\\SQLSERVER12; Initial Catalog = QLCV; Integrated Security = True");
        //public static SqlConnection cnn = new SqlConnection("Data Source = MARINKQH_LAN\\SQLEXPRESS; Initial Catalog = PythonQLNS; User ID = sa; Password = 123456");

        public void connect()
        {
            if (cnn == null)
                cnn = new SqlConnection("Data Source = LAPTOPNEWVN\\SQLSERVER12; Initial Catalog = QLCV; Integrated Security = True");
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }

        public void disconect()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable queryData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            return data;
        }

        public void queryNonReturn(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
        }

    }
}
