namespace Quiz10Mhrs
{
    partial class ReceteYaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_recetekayit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tumunusil = new System.Windows.Forms.Button();
            this.btn_ilacsil = new System.Windows.Forms.Button();
            this.cmb_ilaclar = new System.Windows.Forms.ComboBox();
            this.btn_ilacekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_ilaclar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_recetekayit);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REÇETE YAZ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hastanın Tc Kimlik Numarasını Giriniz :";
            // 
            // btn_recetekayit
            // 
            this.btn_recetekayit.Location = new System.Drawing.Point(218, 340);
            this.btn_recetekayit.Name = "btn_recetekayit";
            this.btn_recetekayit.Size = new System.Drawing.Size(141, 53);
            this.btn_recetekayit.TabIndex = 5;
            this.btn_recetekayit.Text = "REÇETEYI KAYDET";
            this.btn_recetekayit.UseVisualStyleBackColor = true;
            this.btn_recetekayit.Click += new System.EventHandler(this.btn_recetekayit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_ilaclar);
            this.groupBox2.Controls.Add(this.btn_tumunusil);
            this.groupBox2.Controls.Add(this.btn_ilacsil);
            this.groupBox2.Controls.Add(this.cmb_ilaclar);
            this.groupBox2.Controls.Add(this.btn_ilacekle);
            this.groupBox2.Location = new System.Drawing.Point(63, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ILAC EKLE";
            // 
            // btn_tumunusil
            // 
            this.btn_tumunusil.Location = new System.Drawing.Point(286, 153);
            this.btn_tumunusil.Name = "btn_tumunusil";
            this.btn_tumunusil.Size = new System.Drawing.Size(115, 33);
            this.btn_tumunusil.TabIndex = 5;
            this.btn_tumunusil.Text = "Tümünü Sil";
            this.btn_tumunusil.UseVisualStyleBackColor = true;
            this.btn_tumunusil.Click += new System.EventHandler(this.btn_tumunusil_Click);
            // 
            // btn_ilacsil
            // 
            this.btn_ilacsil.Location = new System.Drawing.Point(286, 103);
            this.btn_ilacsil.Name = "btn_ilacsil";
            this.btn_ilacsil.Size = new System.Drawing.Size(115, 33);
            this.btn_ilacsil.TabIndex = 4;
            this.btn_ilacsil.Text = "Ilac Sil";
            this.btn_ilacsil.UseVisualStyleBackColor = true;
            this.btn_ilacsil.Click += new System.EventHandler(this.btn_ilacsil_Click);
            // 
            // cmb_ilaclar
            // 
            this.cmb_ilaclar.FormattingEnabled = true;
            this.cmb_ilaclar.Location = new System.Drawing.Point(17, 29);
            this.cmb_ilaclar.Name = "cmb_ilaclar";
            this.cmb_ilaclar.Size = new System.Drawing.Size(203, 26);
            this.cmb_ilaclar.TabIndex = 1;
            this.cmb_ilaclar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_ilacekle
            // 
            this.btn_ilacekle.Location = new System.Drawing.Point(286, 27);
            this.btn_ilacekle.Name = "btn_ilacekle";
            this.btn_ilacekle.Size = new System.Drawing.Size(115, 33);
            this.btn_ilacekle.TabIndex = 3;
            this.btn_ilacekle.Text = "Ilac Ekle";
            this.btn_ilacekle.UseVisualStyleBackColor = true;
            this.btn_ilacekle.Click += new System.EventHandler(this.btn_ilacekle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 25);
            this.textBox1.TabIndex = 0;
            // 
            // lb_ilaclar
            // 
            this.lb_ilaclar.FormattingEnabled = true;
            this.lb_ilaclar.ItemHeight = 18;
            this.lb_ilaclar.Location = new System.Drawing.Point(17, 87);
            this.lb_ilaclar.Name = "lb_ilaclar";
            this.lb_ilaclar.Size = new System.Drawing.Size(211, 130);
            this.lb_ilaclar.TabIndex = 6;
            // 
            // ReceteYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1083, 641);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReceteYaz";
            this.Text = "ReceteYaz";
            this.Load += new System.EventHandler(this.ReceteYaz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ilacekle;
        private System.Windows.Forms.ComboBox cmb_ilaclar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_recetekayit;
        private System.Windows.Forms.Button btn_tumunusil;
        private System.Windows.Forms.Button btn_ilacsil;
        private System.Windows.Forms.ListBox lb_ilaclar;
    }
}