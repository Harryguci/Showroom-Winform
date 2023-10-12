using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomData
{
    internal class ProcessDatabase
    {
        private string connString = "Data Source=HELLO-WORLD;Initial Catalog=SHOWROOM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;User ID=sa;Password=123456";
        private SqlConnection conn;

        public ProcessDatabase()
        {
            conn = new SqlConnection(connString);
        }

        public void Connect()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
        }

        public void CloseConnect()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
            conn.Dispose();
        }

        public DataTable GetData(string sql)
        {
            DataTable tb = new DataTable();
            this.Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(tb);
            this.CloseConnect();
            return tb;
        }

        public void UpdateData(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            CloseConnect();
            cmd.Dispose();
        }

    }
}
