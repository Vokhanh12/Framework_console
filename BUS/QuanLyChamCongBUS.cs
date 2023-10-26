using System.Data;
using qlcc.DAO;

namespace qlcc.BUS
{
    public class QuanLyChamCongBUS
    {
        public static DataTable? TTNV(string MaCV)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = QuanLyChamCongDAO.TTNV(MaCV);
                MessageBox.Show("Lay danh sach thanh cong");
                return dt;
            }
            catch
            {
                MessageBox.Show("Loi xem danh sach");
                return null;
            }
        }
    }   
}