using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHDT.DTO
{
    public class HoaDonBan
    {
        public string SoHDB { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaKhach { get; set; }
        public int TongTien { get; set; }
    }
}
