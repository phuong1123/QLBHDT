using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DTO
{
    public class HoaDonNhap
    {
        public string SoHDN { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNCC { get; set; }
        public int TongTien { get; set; }
    }
}
