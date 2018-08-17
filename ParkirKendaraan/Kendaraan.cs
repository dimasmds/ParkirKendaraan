using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkirKendaraan
{
    public class Kendaraan
    {
        public string NomorKendaraan { get; set; }
        public decimal Harga { get; set; }
        public TimeSpan JamMasuk { get; set; }
        public string Status { get; set; }
    }
}
