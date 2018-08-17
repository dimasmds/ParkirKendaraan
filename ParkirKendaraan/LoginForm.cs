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
    public partial class LoginForm : Form
    {
        List<Karyawan> Karyawans;

        public LoginForm()
        {
            InitializeComponent();
            Karyawans = new List<Karyawan>();
            textBoxNama.Enabled = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Enabled == false)
            {
                textBoxNama.Enabled = true;
                return;
            }

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxNama.Text == "")
            {
                MessageBox.Show("Isi Semua kolom");
                return;
            }

            foreach (var kar in Karyawans)
            {
                if (kar.Username == textBoxUsername.Text)
                {
                    MessageBox.Show("Anda Sudah Terdaftar !");
                    return;
                }
            }

            string nama = textBoxNama.Text;
            string password = textBoxPassword.Text;
            string username = textBoxUsername.Text;

            Karyawan karyawan = new Karyawan(username, password, nama);
            Karyawans.Add(karyawan);

            MessageBox.Show("Registrasi Berhasil");
            textBoxNama.Text = "";
            textBoxNama.Enabled = false;
            textBoxPassword.Text = "";
            textBoxUsername.Text = "";
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            foreach (var kar in Karyawans)
            {
                if (kar.Username == textBoxUsername.Text && kar.Password == textBoxPassword.Text)
                {
                    MessageBox.Show("Selamat Bekerja " + kar.NamaLengkap);
                    MenuUtama menuUtama = new MenuUtama();
                    menuUtama.NamaKaryawan = kar.NamaLengkap;
                    menuUtama.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Username atau Password salah");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
