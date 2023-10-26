using System.Data;
using System.Data.SqlClient;

namespace qlcc.DAO
{
    public class ConnectDatabase
    {
        
        private const string CONTAINER_IP_ADDRESS = "172.17.0.2";  // Replace with your actual container IP address
        private const string DATABASE_NAME = "QLCHAMCONG";
        private const string PASSWORD = "Aa@123456789";

        private static SqlConnection cnn = new SqlConnection();


         public static void MoKetNoi()
        {
            try
            {
                string sqlcon = $"Server={CONTAINER_IP_ADDRESS},1433;Database={DATABASE_NAME};User Id=sa;Password={PASSWORD};";;
                cnn.ConnectionString = sqlcon;

                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

                 MessageBox.Show("ket noi thanh cong");
               
            }
            catch (Exception)
            {
               MessageBox.Show("ket noi khong thanh cong");
            }


        }

        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;

        }

        public static void ThucThiTryVan(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }

    }
}