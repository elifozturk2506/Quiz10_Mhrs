namespace Quiz10Mhrs
{
    partial class PersonelKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_personelkaydet = new System.Windows.Forms.Button();
            this.llbl_resimekle = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_personeltip = new System.Windows.Forms.ComboBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_personelkaydet);
            this.groupBox1.Controls.Add(this.llbl_resimekle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_personeltip);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(912, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL KAYIT";
            // 
            // btn_personelkaydet
            // 
            this.btn_personelkaydet.Location = new System.Drawing.Point(311, 537);
            this.btn_personelkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_personelkaydet.Name = "btn_personelkaydet";
            this.btn_personelkaydet.Size = new System.Drawing.Size(297, 90);
            this.btn_personelkaydet.TabIndex = 11;
            this.btn_personelkaydet.Text = "PERSONEL KAYDET";
            this.btn_personelkaydet.UseVisualStyleBackColor = true;
            this.btn_personelkaydet.Click += new System.EventHandler(this.btn_personelkaydet_Click);
            // 
            // llbl_resimekle
            // 
            this.llbl_resimekle.AutoSize = true;
            this.llbl_resimekle.Location = new System.Drawing.Point(518, 489);
            this.llbl_resimekle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_resimekle.Name = "llbl_resimekle";
            this.llbl_resimekle.Size = new System.Drawing.Size(80, 18);
            this.llbl_resimekle.TabIndex = 10;
            this.llbl_resimekle.TabStop = true;
            this.llbl_resimekle.Text = "Resim Ekle";
            this.llbl_resimekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_resimekle_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lütfen Resim Seçiniz :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(520, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 209);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lütfen Personel Tipini Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lütfen Personelin Soyadını Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen Personelin Adını Giriniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lütfen Personelin Tc Kimlik Numarasını Giriniz :";
            // 
            // cmb_personeltip
            // 
            this.cmb_personeltip.FormattingEnabled = true;
            this.cmb_personeltip.Items.AddRange(new object[] {
            "Doktor",
            "Hemsire",
            "Hizmetli"});
            this.cmb_personeltip.Location = new System.Drawing.Point(521, 202);
            this.cmb_personeltip.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_personeltip.Name = "cmb_personeltip";
            this.cmb_personeltip.Size = new System.Drawing.Size(312, 26);
            this.cmb_personeltip.TabIndex = 3;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(520, 152);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(312, 25);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(520, 96);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(312, 25);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(521, 48);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(312, 25);
            this.txt_tc.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1064, 741);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llbl_resimekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_personeltip;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_personelkaydet;
    }
}