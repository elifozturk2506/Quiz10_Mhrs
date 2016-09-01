namespace Quiz10Mhrs
{
    partial class ProfilGoruntule
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
            this.dgw_profilgoruntule = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soyadıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreyiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_updatead = new System.Windows.Forms.Button();
            this.btn_updatesoyad = new System.Windows.Forms.Button();
            this.btn_updatesifre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ep_sifre = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_profilgoruntule)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_sifre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgw_profilgoruntule);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROFIL GORUNTULE";
            // 
            // dgw_profilgoruntule
            // 
            this.dgw_profilgoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_profilgoruntule.ContextMenuStrip = this.contextMenuStrip1;
            this.dgw_profilgoruntule.Location = new System.Drawing.Point(25, 37);
            this.dgw_profilgoruntule.Name = "dgw_profilgoruntule";
            this.dgw_profilgoruntule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_profilgoruntule.Size = new System.Drawing.Size(664, 301);
            this.dgw_profilgoruntule.TabIndex = 0;
            this.dgw_profilgoruntule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_profilgoruntule_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adıDüzenleToolStripMenuItem,
            this.soyadıDüzenleToolStripMenuItem,
            this.şifreyiDüzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 92);
            // 
            // adıDüzenleToolStripMenuItem
            // 
            this.adıDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adıDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.adıDüzenleToolStripMenuItem.Name = "adıDüzenleToolStripMenuItem";
            this.adıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.adıDüzenleToolStripMenuItem.Text = "Adı Düzenle";
            this.adıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.adıDüzenleToolStripMenuItem_Click);
            // 
            // soyadıDüzenleToolStripMenuItem
            // 
            this.soyadıDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadıDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.soyadıDüzenleToolStripMenuItem.Name = "soyadıDüzenleToolStripMenuItem";
            this.soyadıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.soyadıDüzenleToolStripMenuItem.Text = "Soyadı Düzenle";
            this.soyadıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.soyadıDüzenleToolStripMenuItem_Click);
            // 
            // şifreyiDüzenleToolStripMenuItem
            // 
            this.şifreyiDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.şifreyiDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.şifreyiDüzenleToolStripMenuItem.Name = "şifreyiDüzenleToolStripMenuItem";
            this.şifreyiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.şifreyiDüzenleToolStripMenuItem.Text = "Şifreyi Düzenle";
            this.şifreyiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.şifreyiDüzenleToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // btn_updatead
            // 
            this.btn_updatead.Location = new System.Drawing.Point(163, 77);
            this.btn_updatead.Name = "btn_updatead";
            this.btn_updatead.Size = new System.Drawing.Size(100, 64);
            this.btn_updatead.TabIndex = 2;
            this.btn_updatead.Text = "Degisikligi Kaydet";
            this.btn_updatead.UseVisualStyleBackColor = true;
            this.btn_updatead.Visible = false;
            this.btn_updatead.Click += new System.EventHandler(this.btn_updatead_Click);
            // 
            // btn_updatesoyad
            // 
            this.btn_updatesoyad.Location = new System.Drawing.Point(163, 78);
            this.btn_updatesoyad.Name = "btn_updatesoyad";
            this.btn_updatesoyad.Size = new System.Drawing.Size(100, 64);
            this.btn_updatesoyad.TabIndex = 3;
            this.btn_updatesoyad.Text = "Degisikligi Kaydet";
            this.btn_updatesoyad.UseVisualStyleBackColor = true;
            this.btn_updatesoyad.Visible = false;
            this.btn_updatesoyad.Click += new System.EventHandler(this.btn_updatesoyad_Click);
            // 
            // btn_updatesifre
            // 
            this.btn_updatesifre.Location = new System.Drawing.Point(163, 78);
            this.btn_updatesifre.Name = "btn_updatesifre";
            this.btn_updatesifre.Size = new System.Drawing.Size(100, 64);
            this.btn_updatesifre.TabIndex = 4;
            this.btn_updatesifre.Text = "Degisikligi Kaydet ";
            this.btn_updatesifre.UseVisualStyleBackColor = true;
            this.btn_updatesifre.Visible = false;
            this.btn_updatesifre.Click += new System.EventHandler(this.btn_updatesifre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_updatesifre);
            this.groupBox2.Controls.Add(this.btn_updatesoyad);
            this.groupBox2.Controls.Add(this.btn_updatead);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(135, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profil Düzenle";
            this.groupBox2.Visible = false;
            // 
            // ep_sifre
            // 
            this.ep_sifre.ContainerControl = this;
            // 
            // ProfilGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1083, 641);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProfilGoruntule";
            this.Text = "ProfilGoruntule";
            this.Load += new System.EventHandler(this.ProfilGoruntule_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_profilgoruntule)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_sifre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_profilgoruntule;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soyadıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreyiDüzenleToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_updatead;
        private System.Windows.Forms.Button btn_updatesifre;
        private System.Windows.Forms.Button btn_updatesoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider ep_sifre;
    }
}