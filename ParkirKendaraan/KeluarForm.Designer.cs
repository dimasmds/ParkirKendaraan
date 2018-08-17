namespace ParkirKendaraan
{
    partial class KeluarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxMobil = new System.Windows.Forms.ListBox();
            this.listBoxMotor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxJamKeluar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJamMasuk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHargaTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxJenisKendaraan = new System.Windows.Forms.TextBox();
            this.buttonPilih = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNoKendaraan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mobil";
            // 
            // listBoxMobil
            // 
            this.listBoxMobil.FormattingEnabled = true;
            this.listBoxMobil.Location = new System.Drawing.Point(114, 40);
            this.listBoxMobil.Name = "listBoxMobil";
            this.listBoxMobil.Size = new System.Drawing.Size(102, 160);
            this.listBoxMobil.TabIndex = 2;
            this.listBoxMobil.SelectedIndexChanged += new System.EventHandler(this.listBoxMobil_SelectedIndexChanged);
            this.listBoxMobil.DoubleClick += new System.EventHandler(this.listBoxMobil_DoubleClick);
            // 
            // listBoxMotor
            // 
            this.listBoxMotor.FormattingEnabled = true;
            this.listBoxMotor.Location = new System.Drawing.Point(6, 40);
            this.listBoxMotor.Name = "listBoxMotor";
            this.listBoxMotor.Size = new System.Drawing.Size(102, 160);
            this.listBoxMotor.TabIndex = 0;
            this.listBoxMotor.SelectedIndexChanged += new System.EventHandler(this.listBoxMotor_SelectedIndexChanged);
            this.listBoxMotor.DoubleClick += new System.EventHandler(this.listBoxMotor_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jam Keluar";
            // 
            // textBoxJamKeluar
            // 
            this.textBoxJamKeluar.Location = new System.Drawing.Point(99, 101);
            this.textBoxJamKeluar.Name = "textBoxJamKeluar";
            this.textBoxJamKeluar.ReadOnly = true;
            this.textBoxJamKeluar.Size = new System.Drawing.Size(100, 20);
            this.textBoxJamKeluar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jam Masuk";
            // 
            // textBoxJamMasuk
            // 
            this.textBoxJamMasuk.Location = new System.Drawing.Point(98, 75);
            this.textBoxJamMasuk.Name = "textBoxJamMasuk";
            this.textBoxJamMasuk.ReadOnly = true;
            this.textBoxJamMasuk.Size = new System.Drawing.Size(100, 20);
            this.textBoxJamMasuk.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(98, 49);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.ReadOnly = true;
            this.textBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarga.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.listBoxMobil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.listBoxMotor);
            this.groupBox2.Location = new System.Drawing.Point(352, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 214);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Kendaraan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Motor";
            // 
            // textBoxHargaTotal
            // 
            this.textBoxHargaTotal.Location = new System.Drawing.Point(98, 222);
            this.textBoxHargaTotal.Name = "textBoxHargaTotal";
            this.textBoxHargaTotal.Size = new System.Drawing.Size(149, 20);
            this.textBoxHargaTotal.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Harga";
            // 
            // textBoxJenisKendaraan
            // 
            this.textBoxJenisKendaraan.Location = new System.Drawing.Point(98, 23);
            this.textBoxJenisKendaraan.Name = "textBoxJenisKendaraan";
            this.textBoxJenisKendaraan.ReadOnly = true;
            this.textBoxJenisKendaraan.Size = new System.Drawing.Size(100, 20);
            this.textBoxJenisKendaraan.TabIndex = 5;
            // 
            // buttonPilih
            // 
            this.buttonPilih.Location = new System.Drawing.Point(254, 28);
            this.buttonPilih.Name = "buttonPilih";
            this.buttonPilih.Size = new System.Drawing.Size(75, 23);
            this.buttonPilih.TabIndex = 17;
            this.buttonPilih.Text = "Pilih";
            this.buttonPilih.UseVisualStyleBackColor = true;
            this.buttonPilih.Click += new System.EventHandler(this.buttonPilih_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jenis Kendaraan";
            // 
            // buttonBayar
            // 
            this.buttonBayar.Location = new System.Drawing.Point(254, 222);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(75, 23);
            this.buttonBayar.TabIndex = 18;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxJamKeluar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxJamMasuk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxHarga);
            this.groupBox1.Controls.Add(this.textBoxJenisKendaraan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 143);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Kendaraan";
            // 
            // textBoxNoKendaraan
            // 
            this.textBoxNoKendaraan.Location = new System.Drawing.Point(122, 30);
            this.textBoxNoKendaraan.Name = "textBoxNoKendaraan";
            this.textBoxNoKendaraan.Size = new System.Drawing.Size(125, 20);
            this.textBoxNoKendaraan.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nomor Kendaraan";
            // 
            // KeluarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxHargaTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPilih);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNoKendaraan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KeluarForm";
            this.Text = "KeluarForm";
            this.Load += new System.EventHandler(this.KeluarForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxMobil;
        private System.Windows.Forms.ListBox listBoxMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJamKeluar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJamMasuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHargaTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxJenisKendaraan;
        private System.Windows.Forms.Button buttonPilih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNoKendaraan;
        private System.Windows.Forms.Label label1;
    }
}