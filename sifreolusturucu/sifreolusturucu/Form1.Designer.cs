namespace sifreolusturucu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.tb_uzunluk = new System.Windows.Forms.TrackBar();
            this.chk_buyukharf = new System.Windows.Forms.CheckBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.lbl_uzunluk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_rakam = new System.Windows.Forms.CheckBox();
            this.chk_kucukharf = new System.Windows.Forms.CheckBox();
            this.chk_ozelkarakter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_uzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre Uzunluğu : ";
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.ForeColor = System.Drawing.Color.PeachPuff;
            this.txt_sifre.Location = new System.Drawing.Point(10, 156);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(185, 25);
            this.txt_sifre.TabIndex = 5;
            // 
            // tb_uzunluk
            // 
            this.tb_uzunluk.Location = new System.Drawing.Point(10, 40);
            this.tb_uzunluk.Maximum = 20;
            this.tb_uzunluk.Name = "tb_uzunluk";
            this.tb_uzunluk.Size = new System.Drawing.Size(185, 45);
            this.tb_uzunluk.TabIndex = 0;
            this.tb_uzunluk.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_uzunluk.Value = 8;
            this.tb_uzunluk.Scroll += new System.EventHandler(this.tb_uzunluk_Scroll);
            // 
            // chk_buyukharf
            // 
            this.chk_buyukharf.AutoSize = true;
            this.chk_buyukharf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_buyukharf.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_buyukharf.ForeColor = System.Drawing.Color.PeachPuff;
            this.chk_buyukharf.Location = new System.Drawing.Point(29, 97);
            this.chk_buyukharf.Name = "chk_buyukharf";
            this.chk_buyukharf.Size = new System.Drawing.Size(54, 23);
            this.chk_buyukharf.TabIndex = 1;
            this.chk_buyukharf.Text = "ABC";
            this.chk_buyukharf.UseVisualStyleBackColor = true;
            // 
            // btn_olustur
            // 
            this.btn_olustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_olustur.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_olustur.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_olustur.Location = new System.Drawing.Point(10, 194);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(185, 36);
            this.btn_olustur.TabIndex = 6;
            this.btn_olustur.Text = "Şifre Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // lbl_uzunluk
            // 
            this.lbl_uzunluk.AutoSize = true;
            this.lbl_uzunluk.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uzunluk.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbl_uzunluk.Location = new System.Drawing.Point(149, 18);
            this.lbl_uzunluk.Name = "lbl_uzunluk";
            this.lbl_uzunluk.Size = new System.Drawing.Size(17, 19);
            this.lbl_uzunluk.TabIndex = 5;
            this.lbl_uzunluk.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Olsun mu ?";
            // 
            // chk_rakam
            // 
            this.chk_rakam.AutoSize = true;
            this.chk_rakam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_rakam.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_rakam.ForeColor = System.Drawing.Color.PeachPuff;
            this.chk_rakam.Location = new System.Drawing.Point(131, 97);
            this.chk_rakam.Name = "chk_rakam";
            this.chk_rakam.Size = new System.Drawing.Size(50, 23);
            this.chk_rakam.TabIndex = 2;
            this.chk_rakam.Text = "024";
            this.chk_rakam.UseVisualStyleBackColor = true;
            // 
            // chk_kucukharf
            // 
            this.chk_kucukharf.AutoSize = true;
            this.chk_kucukharf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_kucukharf.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_kucukharf.ForeColor = System.Drawing.Color.PeachPuff;
            this.chk_kucukharf.Location = new System.Drawing.Point(29, 120);
            this.chk_kucukharf.Name = "chk_kucukharf";
            this.chk_kucukharf.Size = new System.Drawing.Size(50, 23);
            this.chk_kucukharf.TabIndex = 3;
            this.chk_kucukharf.Text = "abc";
            this.chk_kucukharf.UseVisualStyleBackColor = true;
            // 
            // chk_ozelkarakter
            // 
            this.chk_ozelkarakter.AutoSize = true;
            this.chk_ozelkarakter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_ozelkarakter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chk_ozelkarakter.ForeColor = System.Drawing.Color.PeachPuff;
            this.chk_ozelkarakter.Location = new System.Drawing.Point(131, 120);
            this.chk_ozelkarakter.Name = "chk_ozelkarakter";
            this.chk_ozelkarakter.Size = new System.Drawing.Size(50, 23);
            this.chk_ozelkarakter.TabIndex = 4;
            this.chk_ozelkarakter.Text = "?-.#";
            this.chk_ozelkarakter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(207, 255);
            this.Controls.Add(this.chk_ozelkarakter);
            this.Controls.Add(this.chk_kucukharf);
            this.Controls.Add(this.chk_rakam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_uzunluk);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.chk_buyukharf);
            this.Controls.Add(this.tb_uzunluk);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.tb_uzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TrackBar tb_uzunluk;
        private System.Windows.Forms.CheckBox chk_buyukharf;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.Label lbl_uzunluk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_rakam;
        private System.Windows.Forms.CheckBox chk_kucukharf;
        private System.Windows.Forms.CheckBox chk_ozelkarakter;
    }
}

