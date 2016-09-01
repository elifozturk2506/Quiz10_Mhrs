namespace Quiz10Mhrs
{
    partial class İzinTalebi
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
            this.btn_izintalebi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_izinbitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_izinbaslangic = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_izintalebi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_izinbitis);
            this.groupBox1.Controls.Add(this.dtp_izinbaslangic);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İZİN TALEBİ";
            // 
            // btn_izintalebi
            // 
            this.btn_izintalebi.Location = new System.Drawing.Point(104, 193);
            this.btn_izintalebi.Name = "btn_izintalebi";
            this.btn_izintalebi.Size = new System.Drawing.Size(204, 55);
            this.btn_izintalebi.TabIndex = 6;
            this.btn_izintalebi.Text = "IZIN TALEBINDE BULUN";
            this.btn_izintalebi.UseVisualStyleBackColor = true;
            this.btn_izintalebi.Click += new System.EventHandler(this.btn_izintalebi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izin Bitis Tarihi Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izin Baslangıç Tarihi Seçiniz :";
            // 
            // dtp_izinbitis
            // 
            this.dtp_izinbitis.Location = new System.Drawing.Point(233, 125);
            this.dtp_izinbitis.Name = "dtp_izinbitis";
            this.dtp_izinbitis.Size = new System.Drawing.Size(200, 25);
            this.dtp_izinbitis.TabIndex = 3;
            // 
            // dtp_izinbaslangic
            // 
            this.dtp_izinbaslangic.Location = new System.Drawing.Point(233, 47);
            this.dtp_izinbaslangic.Name = "dtp_izinbaslangic";
            this.dtp_izinbaslangic.Size = new System.Drawing.Size(200, 25);
            this.dtp_izinbaslangic.TabIndex = 2;
            // 
            // İzinTalebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1083, 641);
            this.Controls.Add(this.groupBox1);
            this.Name = "İzinTalebi";
            this.Text = "İzinTalebi";
            this.Load += new System.EventHandler(this.İzinTalebi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_izintalebi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_izinbitis;
        private System.Windows.Forms.DateTimePicker dtp_izinbaslangic;
    }
}