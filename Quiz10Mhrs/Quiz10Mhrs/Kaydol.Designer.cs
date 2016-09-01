namespace Quiz10Mhrs
{
    partial class Kaydol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaydol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.txt_sifrekontrol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rd_erkek = new System.Windows.Forms.RadioButton();
            this.rd_kadin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ap_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.ap_soyad = new System.Windows.Forms.ErrorProvider(this.components);
            this.ap_tc = new System.Windows.Forms.ErrorProvider(this.components);
            this.ap_sifre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ap_sifretekrar = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ap_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_soyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_tc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_sifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_sifretekrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kaydol);
            this.groupBox1.Controls.Add(this.txt_sifrekontrol);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rd_erkek);
            this.groupBox1.Controls.Add(this.rd_kadin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜYE KAYIT";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.Location = new System.Drawing.Point(157, 379);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(174, 87);
            this.btn_kaydol.TabIndex = 21;
            this.btn_kaydol.Text = "KAYDOL";
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // txt_sifrekontrol
            // 
            this.txt_sifrekontrol.Location = new System.Drawing.Point(157, 323);
            this.txt_sifrekontrol.Name = "txt_sifrekontrol";
            this.txt_sifrekontrol.PasswordChar = '*';
            this.txt_sifrekontrol.Size = new System.Drawing.Size(174, 25);
            this.txt_sifrekontrol.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Şifre Tekrar :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 25);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Doğum Tarihi :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(157, 276);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(174, 25);
            this.txt_sifre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şifre Giriniz :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(157, 137);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(174, 25);
            this.txt_tc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "T.C. :";
            // 
            // rd_erkek
            // 
            this.rd_erkek.AutoSize = true;
            this.rd_erkek.Location = new System.Drawing.Point(252, 187);
            this.rd_erkek.Name = "rd_erkek";
            this.rd_erkek.Size = new System.Drawing.Size(66, 22);
            this.rd_erkek.TabIndex = 6;
            this.rd_erkek.Text = "Erkek";
            this.rd_erkek.UseVisualStyleBackColor = true;
            // 
            // rd_kadin
            // 
            this.rd_kadin.AutoSize = true;
            this.rd_kadin.Checked = true;
            this.rd_kadin.Location = new System.Drawing.Point(157, 185);
            this.rd_kadin.Name = "rd_kadin";
            this.rd_kadin.Size = new System.Drawing.Size(66, 22);
            this.rd_kadin.TabIndex = 5;
            this.rd_kadin.TabStop = true;
            this.rd_kadin.Text = "Kadın";
            this.rd_kadin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cinsiyet :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(157, 95);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(174, 25);
            this.txt_soyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad :";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(157, 39);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(174, 25);
            this.txt_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // ap_ad
            // 
            this.ap_ad.ContainerControl = this;
            // 
            // ap_soyad
            // 
            this.ap_soyad.ContainerControl = this;
            // 
            // ap_tc
            // 
            this.ap_tc.ContainerControl = this;
            // 
            // ap_sifre
            // 
            this.ap_sifre.ContainerControl = this;
            // 
            // ap_sifretekrar
            // 
            this.ap_sifretekrar.ContainerControl = this;
            // 
            // Kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1083, 641);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kaydol";
            this.Text = "Kaydol";
            this.Load += new System.EventHandler(this.Kaydol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ap_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_soyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_tc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_sifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ap_sifretekrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.TextBox txt_sifrekontrol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rd_erkek;
        private System.Windows.Forms.RadioButton rd_kadin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ap_ad;
        private System.Windows.Forms.ErrorProvider ap_soyad;
        private System.Windows.Forms.ErrorProvider ap_tc;
        private System.Windows.Forms.ErrorProvider ap_sifre;
        private System.Windows.Forms.ErrorProvider ap_sifretekrar;

    }
}