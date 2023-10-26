namespace qlcc.DTO
{
    public class CongViecDTO
    {
        private string? _maCV;
        private string? _tenCV;
        private int? _donGia;

        public CongViecDTO(string? maCV, string? tenCV, int? donGia)
        {
            MaCV = maCV;
            TenCV = tenCV;
            DonGia = donGia;
        }

        public string? MaCV { get => _maCV; set => _maCV = value; }
        public string? TenCV { get => _tenCV; set => _tenCV = value; }
        public int? DonGia { get => _donGia; set => _donGia = value; }
    }
}