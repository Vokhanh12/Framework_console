using Microsoft.VisualBasic;

namespace qlcc.DTO
{
    public class NhanVienDTO
    {
        private string? _MaNV;
        private string? _HoTen;
        private bool _phai;
        private double? _HSluong;
        private DateTime _NgaySinh;
        private string? _NoiSinh;

        public NhanVienDTO(string? maNV, string? hoTen, bool phai, double? hSluong, DateTime ngaySinh, string? noiSinh)
        {
            MaNV = maNV;
            HoTen = hoTen;
            Phai = phai;
            HSluong = hSluong;
            NgaySinh = ngaySinh;
            NoiSinh = noiSinh;
        }

        public string? MaNV { get => _MaNV; set => _MaNV = value; }
        public string? HoTen { get => _HoTen; set => _HoTen = value; }
        public bool Phai { get => _phai; set => _phai = value; }
        public double? HSluong { get => _HSluong; set => _HSluong = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string? NoiSinh { get => _NoiSinh; set => _NoiSinh = value; }
    }
}