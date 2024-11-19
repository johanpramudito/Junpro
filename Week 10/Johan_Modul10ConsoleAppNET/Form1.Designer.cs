namespace Johan_Modul10ConsoleAppNET
{
    partial class Form1
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
            this.lbl_cekhargaongkir = new System.Windows.Forms.Label();
            this.lbl_asal = new System.Windows.Forms.Label();
            this.tb_asal = new System.Windows.Forms.TextBox();
            this.lbl_tujuan = new System.Windows.Forms.Label();
            this.tb_tujuan = new System.Windows.Forms.TextBox();
            this.lbl_berat = new System.Windows.Forms.Label();
            this.tb_berat = new System.Windows.Forms.TextBox();
            this.rb_pos = new System.Windows.Forms.RadioButton();
            this.rb_jne = new System.Windows.Forms.RadioButton();
            this.rb_tiki = new System.Windows.Forms.RadioButton();
            this.bt_cekhargalayanan = new System.Windows.Forms.Button();
            this.gb_detailLayanan = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbl_cekhargaongkir
            // 
            this.lbl_cekhargaongkir.AutoSize = true;
            this.lbl_cekhargaongkir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cekhargaongkir.Location = new System.Drawing.Point(44, 9);
            this.lbl_cekhargaongkir.Name = "lbl_cekhargaongkir";
            this.lbl_cekhargaongkir.Size = new System.Drawing.Size(221, 29);
            this.lbl_cekhargaongkir.TabIndex = 0;
            this.lbl_cekhargaongkir.Text = "Cek Harga Ongkir";
            // 
            // lbl_asal
            // 
            this.lbl_asal.AutoSize = true;
            this.lbl_asal.Location = new System.Drawing.Point(29, 48);
            this.lbl_asal.Name = "lbl_asal";
            this.lbl_asal.Size = new System.Drawing.Size(115, 13);
            this.lbl_asal.TabIndex = 1;
            this.lbl_asal.Text = "Kota / Kabupaten Asal";
            // 
            // tb_asal
            // 
            this.tb_asal.Location = new System.Drawing.Point(32, 64);
            this.tb_asal.Name = "tb_asal";
            this.tb_asal.Size = new System.Drawing.Size(244, 20);
            this.tb_asal.TabIndex = 2;
            // 
            // lbl_tujuan
            // 
            this.lbl_tujuan.AutoSize = true;
            this.lbl_tujuan.Location = new System.Drawing.Point(29, 132);
            this.lbl_tujuan.Name = "lbl_tujuan";
            this.lbl_tujuan.Size = new System.Drawing.Size(128, 13);
            this.lbl_tujuan.TabIndex = 3;
            this.lbl_tujuan.Text = "Kota / Kabupaten Tujuan";
            // 
            // tb_tujuan
            // 
            this.tb_tujuan.Location = new System.Drawing.Point(32, 148);
            this.tb_tujuan.Name = "tb_tujuan";
            this.tb_tujuan.Size = new System.Drawing.Size(244, 20);
            this.tb_tujuan.TabIndex = 4;
            // 
            // lbl_berat
            // 
            this.lbl_berat.AutoSize = true;
            this.lbl_berat.Location = new System.Drawing.Point(29, 212);
            this.lbl_berat.Name = "lbl_berat";
            this.lbl_berat.Size = new System.Drawing.Size(64, 13);
            this.lbl_berat.TabIndex = 5;
            this.lbl_berat.Text = "Berat (gram)";
            // 
            // tb_berat
            // 
            this.tb_berat.Location = new System.Drawing.Point(32, 228);
            this.tb_berat.Name = "tb_berat";
            this.tb_berat.Size = new System.Drawing.Size(244, 20);
            this.tb_berat.TabIndex = 6;
            // 
            // rb_pos
            // 
            this.rb_pos.AutoSize = true;
            this.rb_pos.Location = new System.Drawing.Point(70, 271);
            this.rb_pos.Name = "rb_pos";
            this.rb_pos.Size = new System.Drawing.Size(47, 17);
            this.rb_pos.TabIndex = 7;
            this.rb_pos.TabStop = true;
            this.rb_pos.Text = "POS";
            this.rb_pos.UseVisualStyleBackColor = true;
            // 
            // rb_jne
            // 
            this.rb_jne.AutoSize = true;
            this.rb_jne.Location = new System.Drawing.Point(135, 271);
            this.rb_jne.Name = "rb_jne";
            this.rb_jne.Size = new System.Drawing.Size(45, 17);
            this.rb_jne.TabIndex = 8;
            this.rb_jne.TabStop = true;
            this.rb_jne.Text = "JNE";
            this.rb_jne.UseVisualStyleBackColor = true;
            // 
            // rb_tiki
            // 
            this.rb_tiki.AutoSize = true;
            this.rb_tiki.Location = new System.Drawing.Point(198, 271);
            this.rb_tiki.Name = "rb_tiki";
            this.rb_tiki.Size = new System.Drawing.Size(45, 17);
            this.rb_tiki.TabIndex = 9;
            this.rb_tiki.TabStop = true;
            this.rb_tiki.Text = "TIKI";
            this.rb_tiki.UseVisualStyleBackColor = true;
            // 
            // bt_cekhargalayanan
            // 
            this.bt_cekhargalayanan.Location = new System.Drawing.Point(32, 304);
            this.bt_cekhargalayanan.Name = "bt_cekhargalayanan";
            this.bt_cekhargalayanan.Size = new System.Drawing.Size(244, 23);
            this.bt_cekhargalayanan.TabIndex = 10;
            this.bt_cekhargalayanan.Text = "Cek Harga Layanan";
            this.bt_cekhargalayanan.UseVisualStyleBackColor = true;
            this.bt_cekhargalayanan.Click += new System.EventHandler(this.bt_cekhargalayanan_Click);
            // 
            // gb_detailLayanan
            // 
            this.gb_detailLayanan.Location = new System.Drawing.Point(319, 12);
            this.gb_detailLayanan.Name = "gb_detailLayanan";
            this.gb_detailLayanan.Size = new System.Drawing.Size(290, 315);
            this.gb_detailLayanan.TabIndex = 11;
            this.gb_detailLayanan.TabStop = false;
            this.gb_detailLayanan.Text = "Detail Layanan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 354);
            this.Controls.Add(this.gb_detailLayanan);
            this.Controls.Add(this.bt_cekhargalayanan);
            this.Controls.Add(this.rb_tiki);
            this.Controls.Add(this.rb_jne);
            this.Controls.Add(this.rb_pos);
            this.Controls.Add(this.tb_berat);
            this.Controls.Add(this.lbl_berat);
            this.Controls.Add(this.tb_tujuan);
            this.Controls.Add(this.lbl_tujuan);
            this.Controls.Add(this.tb_asal);
            this.Controls.Add(this.lbl_asal);
            this.Controls.Add(this.lbl_cekhargaongkir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cekhargaongkir;
        private System.Windows.Forms.Label lbl_asal;
        private System.Windows.Forms.TextBox tb_asal;
        private System.Windows.Forms.Label lbl_tujuan;
        private System.Windows.Forms.TextBox tb_tujuan;
        private System.Windows.Forms.Label lbl_berat;
        private System.Windows.Forms.TextBox tb_berat;
        private System.Windows.Forms.RadioButton rb_pos;
        private System.Windows.Forms.RadioButton rb_jne;
        private System.Windows.Forms.RadioButton rb_tiki;
        private System.Windows.Forms.Button bt_cekhargalayanan;
        private System.Windows.Forms.GroupBox gb_detailLayanan;
    }
}