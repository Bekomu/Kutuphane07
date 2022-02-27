namespace Kutuphane07.UI
{
    partial class HesabimForm
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
            this.gboxBilgiler = new System.Windows.Forms.GroupBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKitapTeslimEt = new System.Windows.Forms.Button();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSonTeslim = new System.Windows.Forms.Label();
            this.dgvOduncAlinan = new System.Windows.Forms.DataGridView();
            this.gboxBilgiler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncAlinan)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBilgiler
            // 
            this.gboxBilgiler.Controls.Add(this.lblParola);
            this.gboxBilgiler.Controls.Add(this.label7);
            this.gboxBilgiler.Controls.Add(this.lblKullaniciAdi);
            this.gboxBilgiler.Controls.Add(this.label5);
            this.gboxBilgiler.Controls.Add(this.lblAdSoyad);
            this.gboxBilgiler.Controls.Add(this.label3);
            this.gboxBilgiler.Controls.Add(this.lblKullaniciId);
            this.gboxBilgiler.Controls.Add(this.label2);
            this.gboxBilgiler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gboxBilgiler.Location = new System.Drawing.Point(13, 14);
            this.gboxBilgiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxBilgiler.Name = "gboxBilgiler";
            this.gboxBilgiler.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxBilgiler.Size = new System.Drawing.Size(320, 247);
            this.gboxBilgiler.TabIndex = 0;
            this.gboxBilgiler.TabStop = false;
            this.gboxBilgiler.Text = "Kullanıcı Bilgileri";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(123, 208);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(104, 20);
            this.lblParola.TabIndex = 7;
            this.lblParola.Text = "-------------------";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Parola :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(123, 146);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(104, 20);
            this.lblKullaniciAdi.TabIndex = 5;
            this.lblKullaniciAdi.Text = "-------------------";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı Adı :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(123, 89);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(104, 20);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "-------------------";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad :";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciId.Location = new System.Drawing.Point(9, 53);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(198, 17);
            this.lblKullaniciId.TabIndex = 1;
            this.lblKullaniciId.Text = "--------------------------------------";
            this.lblKullaniciId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapTeslimEt);
            this.groupBox1.Controls.Add(this.dtpTeslimTarihi);
            this.groupBox1.Controls.Add(this.lblSonTeslim);
            this.groupBox1.Controls.Add(this.dgvOduncAlinan);
            this.groupBox1.Location = new System.Drawing.Point(341, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(492, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünç Alınan Kitaplar";
            // 
            // btnKitapTeslimEt
            // 
            this.btnKitapTeslimEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapTeslimEt.Location = new System.Drawing.Point(370, 208);
            this.btnKitapTeslimEt.Name = "btnKitapTeslimEt";
            this.btnKitapTeslimEt.Size = new System.Drawing.Size(115, 30);
            this.btnKitapTeslimEt.TabIndex = 3;
            this.btnKitapTeslimEt.Text = "Kitap Teslim Et";
            this.btnKitapTeslimEt.UseVisualStyleBackColor = true;
            this.btnKitapTeslimEt.Click += new System.EventHandler(this.btnKitapTeslimEt_Click);
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(135, 211);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(229, 23);
            this.dtpTeslimTarihi.TabIndex = 2;
            // 
            // lblSonTeslim
            // 
            this.lblSonTeslim.AutoSize = true;
            this.lblSonTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonTeslim.Location = new System.Drawing.Point(7, 214);
            this.lblSonTeslim.Name = "lblSonTeslim";
            this.lblSonTeslim.Size = new System.Drawing.Size(126, 17);
            this.lblSonTeslim.TabIndex = 1;
            this.lblSonTeslim.Text = "Son Teslim Tarihi :";
            // 
            // dgvOduncAlinan
            // 
            this.dgvOduncAlinan.AllowUserToAddRows = false;
            this.dgvOduncAlinan.AllowUserToDeleteRows = false;
            this.dgvOduncAlinan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncAlinan.Location = new System.Drawing.Point(7, 27);
            this.dgvOduncAlinan.Name = "dgvOduncAlinan";
            this.dgvOduncAlinan.ReadOnly = true;
            this.dgvOduncAlinan.RowHeadersVisible = false;
            this.dgvOduncAlinan.Size = new System.Drawing.Size(478, 173);
            this.dgvOduncAlinan.TabIndex = 0;
            // 
            // HesabimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 273);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxBilgiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HesabimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HesabimForm";
            this.gboxBilgiler.ResumeLayout(false);
            this.gboxBilgiler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncAlinan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBilgiler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKitapTeslimEt;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Label lblSonTeslim;
        private System.Windows.Forms.DataGridView dgvOduncAlinan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKullaniciId;
    }
}