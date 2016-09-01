namespace Quiz10Mhrs
{
    partial class RandevuAl1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_doktorlar = new System.Windows.Forms.ComboBox();
            this.btn_randevual = new System.Windows.Forms.Button();
            this.grup_randevuSaati = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtp_randevutarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_bolumler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ep_randevusaati = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_randevutarihi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grup_randevuSaati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_randevusaati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_randevutarihi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_doktorlar);
            this.groupBox1.Controls.Add(this.btn_randevual);
            this.groupBox1.Controls.Add(this.grup_randevuSaati);
            this.groupBox1.Controls.Add(this.dtp_randevutarihi);
            this.groupBox1.Controls.Add(this.cmb_bolumler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RANDEVU AL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_doktorlar
            // 
            this.cmb_doktorlar.FormattingEnabled = true;
            this.cmb_doktorlar.Location = new System.Drawing.Point(210, 56);
            this.cmb_doktorlar.Name = "cmb_doktorlar";
            this.cmb_doktorlar.Size = new System.Drawing.Size(121, 26);
            this.cmb_doktorlar.TabIndex = 19;
            this.cmb_doktorlar.SelectedIndexChanged += new System.EventHandler(this.cmb_doktorlar_SelectedIndexChanged);
            // 
            // btn_randevual
            // 
            this.btn_randevual.Location = new System.Drawing.Point(210, 335);
            this.btn_randevual.Name = "btn_randevual";
            this.btn_randevual.Size = new System.Drawing.Size(213, 25);
            this.btn_randevual.TabIndex = 18;
            this.btn_randevual.Text = "RANDEVU AL";
            this.btn_randevual.UseVisualStyleBackColor = true;
            this.btn_randevual.Click += new System.EventHandler(this.btn_randevual_Click);
            // 
            // grup_randevuSaati
            // 
            this.grup_randevuSaati.Controls.Add(this.radioButton13);
            this.grup_randevuSaati.Controls.Add(this.radioButton14);
            this.grup_randevuSaati.Controls.Add(this.radioButton15);
            this.grup_randevuSaati.Controls.Add(this.radioButton10);
            this.grup_randevuSaati.Controls.Add(this.radioButton11);
            this.grup_randevuSaati.Controls.Add(this.radioButton12);
            this.grup_randevuSaati.Controls.Add(this.radioButton7);
            this.grup_randevuSaati.Controls.Add(this.radioButton8);
            this.grup_randevuSaati.Controls.Add(this.radioButton9);
            this.grup_randevuSaati.Controls.Add(this.radioButton4);
            this.grup_randevuSaati.Controls.Add(this.radioButton5);
            this.grup_randevuSaati.Controls.Add(this.radioButton6);
            this.grup_randevuSaati.Controls.Add(this.radioButton3);
            this.grup_randevuSaati.Controls.Add(this.radioButton2);
            this.grup_randevuSaati.Controls.Add(this.radioButton1);
            this.grup_randevuSaati.Location = new System.Drawing.Point(210, 119);
            this.grup_randevuSaati.Name = "grup_randevuSaati";
            this.grup_randevuSaati.Size = new System.Drawing.Size(213, 195);
            this.grup_randevuSaati.TabIndex = 17;
            this.grup_randevuSaati.TabStop = false;
            this.grup_randevuSaati.Text = "Randevu Saati Seçiniz :";
            this.grup_randevuSaati.Enter += new System.EventHandler(this.grup_randevuSaati_Enter);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(148, 169);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(59, 22);
            this.radioButton13.TabIndex = 14;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "16.30";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(78, 169);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(61, 22);
            this.radioButton14.TabIndex = 13;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "16.00";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(7, 169);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(59, 22);
            this.radioButton15.TabIndex = 12;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "15.30";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(148, 136);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(61, 22);
            this.radioButton10.TabIndex = 11;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "15.00";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(78, 136);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(59, 22);
            this.radioButton11.TabIndex = 10;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "14.30";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(7, 136);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(61, 22);
            this.radioButton12.TabIndex = 9;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "14.00";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(148, 101);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(59, 22);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "13.30";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(78, 101);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(61, 22);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "12.00";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 101);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(55, 22);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "11.30";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(148, 67);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 22);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "11.00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(78, 67);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(61, 22);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "10.30";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 67);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(63, 22);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "10.00";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(148, 33);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "09.30";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(78, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "09.00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "08.30";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dtp_randevutarihi
            // 
            this.dtp_randevutarihi.Enabled = false;
            this.dtp_randevutarihi.Location = new System.Drawing.Point(210, 88);
            this.dtp_randevutarihi.Name = "dtp_randevutarihi";
            this.dtp_randevutarihi.Size = new System.Drawing.Size(200, 25);
            this.dtp_randevutarihi.TabIndex = 16;
            this.dtp_randevutarihi.ValueChanged += new System.EventHandler(this.dtp_randevutarihi_ValueChanged);
            // 
            // cmb_bolumler
            // 
            this.cmb_bolumler.FormattingEnabled = true;
            this.cmb_bolumler.Location = new System.Drawing.Point(210, 24);
            this.cmb_bolumler.Name = "cmb_bolumler";
            this.cmb_bolumler.Size = new System.Drawing.Size(121, 26);
            this.cmb_bolumler.TabIndex = 2;
            this.cmb_bolumler.SelectedIndexChanged += new System.EventHandler(this.cmb_bolumler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Bölüm Seçiniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ep_randevusaati
            // 
            this.ep_randevusaati.ContainerControl = this;
            // 
            // ep_randevutarihi
            // 
            this.ep_randevutarihi.ContainerControl = this;
            // 
            // RandevuAl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1083, 641);
            this.Controls.Add(this.groupBox1);
            this.Name = "RandevuAl1";
            this.Text = "RandevuAl1";
            this.Load += new System.EventHandler(this.RandevuAl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grup_randevuSaati.ResumeLayout(false);
            this.grup_randevuSaati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_randevusaati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_randevutarihi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_bolumler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_doktorlar;
        private System.Windows.Forms.Button btn_randevual;
        private System.Windows.Forms.GroupBox grup_randevuSaati;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtp_randevutarihi;
        private System.Windows.Forms.ErrorProvider ep_randevusaati;
        private System.Windows.Forms.ErrorProvider ep_randevutarihi;
    }
}