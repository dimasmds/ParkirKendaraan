using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkirKendaraan
{
    public class Motor : Kendaraan
    {
        public Motor(string noPlat)
        {
            Harga = 1000;
            NomorKendaraan = noPlat;
            Status = "MASUK";
        }
    }
}
