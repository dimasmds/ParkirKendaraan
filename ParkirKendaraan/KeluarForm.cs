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
    public partial class KeluarForm : Form
    {
        public DataKendaraan Kendaraans;

        public KeluarForm()
        {
            InitializeComponent();
        }

        public void populateKendaraan()
        {
            listBoxMobil.Items.Clear();
            listBoxMotor.Items.Clear();

            foreach (var ken in Kendaraans.Items)
            {
                if (ken is Mobil && ken.Status == "MASUK")
                {
                    listBoxMobil.Items.Add(ken.NomorKendaraan);
                }
                else if (ken is Motor && ken.Status == "MASUK")
                {
                    listBoxMotor.Items.Add(ken.NomorKendaraan);
                }
            }
        }

        private void KeluarForm_Load(object sender, EventArgs e)
        {
            populateKendaraan();
        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {
            foreach (var ken in Kendaraans.Items)
            {
                if (ken.NomorKendaraan == textBoxNoKendaraan.Text.ToUpper())
                {
                    textBoxJenisKendaraan.Text = (ken is Mobil) ? "Mobil" : "Motor";
                    textBoxHarga.Text = ken.Harga.ToString();
                    textBoxJamMasuk.Text = ken.JamMasuk.ToString();
                    textBoxJamKeluar.Text = DateTime.Now.TimeOfDay.ToString();
                    textBoxHargaTotal.Text = hitungBayar(ken).ToString();
                    textBoxNoKendaraan.Enabled = false;
                    return;
                }
            }

            MessageBox.Show("Data tidak ditemukan");
        }

        public decimal hitungBayar(Kendaraan kendaraan)
        {
            TimeSpan totalDurasi = DateTime.Now.TimeOfDay - kendaraan.JamMasuk;
            int intTotalDurasi = (int)totalDurasi.TotalHours > 1 ? (int)totalDurasi.TotalHours : 1;
            return kendaraan.Harga * intTotalDurasi;
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Akan membayar parkir Nomor Kendaraan " + textBoxNoKendaraan.Text + " ?", "Peringatan !", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                foreach (var ken in Kendaraans.Items)
                {
                    if (ken.NomorKendaraan == textBoxNoKendaraan.Text.ToUpper())
                    {
                        if (ken.Status == "MASUK")
                        {
                            ken.Status = "KELUAR";
                            clearAllTextBox();
                            populateKendaraan();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Kendaraan status sudah keluar/Bayar");
                        }
                    }
                }
            }
            else
            {
                return;
            }
            

            MessageBox.Show("Tidak bisa melakukan pembayaran kosong");
        }

        public void clearAllTextBox()
        {
            textBoxNoKendaraan.Enabled = true;
            textBoxNoKendaraan.Text = "";
            textBoxJenisKendaraan.Text = "";
            textBoxHarga.Text = "";
            textBoxJamMasuk.Text = "";
            textBoxJamKeluar.Text = "";
            textBoxHargaTotal.Text = "";
        }

        private void listBoxMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetListBox(listBoxMobil);
        }

       
        private void listBoxMobil_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetListBox(listBoxMotor);
        }

        public void resetListBox(ListBox listBox)
        {
            listBox.ResetText();
            listBox.SelectedIndex = -1;
        }

        private void listBoxMotor_DoubleClick(object sender, EventArgs e)
        {
            textBoxNoKendaraan.Text = listBoxMotor.Text;
        }

        private void listBoxMobil_DoubleClick(object sender, EventArgs e)
        {
            textBoxNoKendaraan.Text = listBoxMobil.Text;
        }
    }
}
