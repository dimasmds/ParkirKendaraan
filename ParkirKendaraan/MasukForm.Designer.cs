namespace ParkirKendaraan
{
    partial class MasukForm
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
            this.textBoxJamMasuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxJenisKendaraan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNomorKendaraan = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxJamMasuk
            // 
            this.textBoxJamMasuk.Location = new System.Drawing.Point(162, 124);
            this.textBoxJamMasuk.Name = "textBoxJamMasuk";
            this.textBoxJamMasuk.Size = new System.Drawing.Size(48, 20);
            this.textBoxJamMasuk.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Jenis Kendaraan";
            // 
            // comboBoxJenisKendaraan
            // 
            this.comboBoxJenisKendaraan.FormattingEnabled = true;
            this.comboBoxJenisKendaraan.Location = new System.Drawing.Point(162, 71);
            this.comboBoxJenisKendaraan.Name = "comboBoxJenisKendaraan";
            this.comboBoxJenisKendaraan.Size = new System.Drawing.Size(186, 21);
            this.comboBoxJenisKendaraan.TabIndex = 22;
            this.comboBoxJenisKendaraan.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisKendaraan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nomor Kendaraan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNomorKendaraan
            // 
            this.textBoxNomorKendaraan.Location = new System.Drawing.Point(162, 44);
            this.textBoxNomorKendaraan.Name = "textBoxNomorKendaraan";
            this.textBoxNomorKendaraan.Size = new System.Drawing.Size(186, 20);
            this.textBoxNomorKendaraan.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Harga";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(162, 98);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(75, 20);
            this.textBoxHarga.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Jam Masuk";
            // 
            // MasukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 244);
            this.Controls.Add(this.textBoxJamMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxJenisKendaraan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNomorKendaraan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MasukForm";
            this.Text = "MasukForm";
            this.Load += new System.EventHandler(this.MasukForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJamMasuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxJenisKendaraan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomorKendaraan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label label3;
    }
}