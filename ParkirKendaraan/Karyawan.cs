using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkirKendaraan
{
    class Karyawan
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaLengkap { get; set; }

        public Karyawan(string username, string password, string nama)
        {
            Username = username;
            Password = password;
            NamaLengkap = nama;
        }
    }
}
