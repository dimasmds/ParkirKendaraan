using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirKendaraan
{
    public partial class MenuUtama : Form
    {
        DataKendaraan dataKendaraan = new DataKendaraan();
        public string NamaKaryawan { get; set; }

        public MenuUtama()
        {
            InitializeComponent();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            labelNama.Text = NamaKaryawan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasukForm masukForm = new MasukForm();
            masukForm.Kendaraans = dataKendaraan;
            masukForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeluarForm keluarForm = new KeluarForm();
            keluarForm.Kendaraans = dataKendaraan;
            keluarForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
