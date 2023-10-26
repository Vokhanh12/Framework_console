using System.Data;

namespace qlcc.DAO
{
    public class QuanLyChamCongDAO
    {
        public static DataTable TTNV(string MaCV)
        {
            string sql = "SELECT nv.MaNV, nv.HoTen, nv.Phai, nv.HSLuong, nv.NgaySinh, nv.NoiSinh, cc.KLCV "+
                         "FROM NHANVIEN nv " +
                         "JOIN CHAMCONG cc ON nv.MaNV = cc.MaNV " +
                         $"WHERE cc.MaCV = '{MaCV}'";
            
            DataTable dt = new DataTable();

            dt = ConnectDatabase.DocDuLieu(sql);

            return dt;

        }
    }
}