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
    public partial class MasukForm : Form
    {
        public DataKendaraan Kendaraans;
        Kendaraan kendaraan;

        public MasukForm()
        {
            InitializeComponent();
        }

        private void MasukForm_Load(object sender, EventArgs e)
        {
            comboBoxJenisKendaraan.Items.Add("Mobil");
            comboBoxJenisKendaraan.Items.Add("Motor");
            comboBoxJenisKendaraan.SelectedIndex = 0;
            textBoxHarga.ReadOnly = true;
            textBoxJamMasuk.Text = DateTime.Now.ToShortTimeString();
            textBoxJamMasuk.ReadOnly = true;
        }

        private void comboBoxJenisKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxJenisKendaraan.Text == "Mobil")
            {
                textBoxHarga.Text = "Rp. 2000/Jam";
                textBoxJamMasuk.Text = DateTime.Now.ToShortTimeString();
            }
            else
            {
                textBoxHarga.Text = "Rp. 1000/Jam";
                textBoxJamMasuk.Text = DateTime.Now.ToShortTimeString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxJenisKendaraan.Text == "Mobil")
            {
                kendaraan = new Mobil(textBoxNomorKendaraan.Text.ToUpper());
                kendaraan.Harga = 2000;
            }
            else
            {
                kendaraan = new Motor(textBoxNomorKendaraan.Text.ToUpper());
                kendaraan.Harga = 1000;
            }

            kendaraan.JamMasuk = DateTime.Now.TimeOfDay;

            Kendaraans.Items.Add(kendaraan);
            MessageBox.Show("Data telah dimasukan");
        }
    }
}
