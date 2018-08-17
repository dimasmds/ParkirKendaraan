using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkirKendaraan
{
    public class Mobil : Kendaraan
    {
        public Mobil(string NomoPlat)
        {
            NomorKendaraan = NomoPlat;
            Harga = 2000;
            Status = "MASUK";
        }
    }
}
