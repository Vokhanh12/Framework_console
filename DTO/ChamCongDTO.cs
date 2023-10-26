using System.Runtime.CompilerServices;

namespace qlcc.DTO
{
    public class ChamCongDTO 
    {
        private string? _maNV;

        private string? _maCV;
        private int? _klcv;

        public ChamCongDTO(string? maNV, string? maCV, int? klcv)
        {
            MaNV = maNV;
            MaCV = maCV;
            Klcv = klcv;
        }

        public string? MaNV { get => _maNV; set => _maNV = value; }
        public string? MaCV { get => _maCV; set => _maCV = value; }
        public int? Klcv { get => _klcv; set => _klcv = value; }
    }
}