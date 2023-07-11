namespace DovizOfisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.btnSatısYap = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDolarAlis = new System.Windows.Forms.Button();
            this.btnDolarSatis = new System.Windows.Forms.Button();
            this.btnEuroAlis = new System.Windows.Forms.Button();
            this.btnEuroSatis = new System.Windows.Forms.Button();
            this.btnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Alış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış:";
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarAlis.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolarAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDolarAlis.Location = new System.Drawing.Point(184, 40);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(29, 29);
            this.lblDolarAlis.TabIndex = 4;
            this.lblDolarAlis.Text = "0";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSatis.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolarSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDolarSatis.Location = new System.Drawing.Point(184, 85);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(29, 29);
            this.lblDolarSatis.TabIndex = 5;
            this.lblDolarSatis.Text = "0";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroAlis.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEuroAlis.Location = new System.Drawing.Point(174, 172);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(29, 29);
            this.lblEuroAlis.TabIndex = 6;
            this.lblEuroAlis.Text = "0";
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSatis.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEuroSatis.Location = new System.Drawing.Point(174, 214);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(29, 29);
            this.lblEuroSatis.TabIndex = 7;
            this.lblEuroSatis.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSatisYap2);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.btnSatısYap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(179, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 312);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtKalan
            // 
            this.txtKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalan.Location = new System.Drawing.Point(149, 177);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(253, 26);
            this.txtKalan.TabIndex = 17;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(149, 138);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(253, 26);
            this.txtTutar.TabIndex = 16;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(149, 96);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(253, 26);
            this.txtMiktar.TabIndex = 15;
            // 
            // txtKur
            // 
            this.txtKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKur.Location = new System.Drawing.Point(149, 51);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(253, 26);
            this.txtKur.TabIndex = 14;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // btnSatısYap
            // 
            this.btnSatısYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatısYap.Location = new System.Drawing.Point(149, 238);
            this.btnSatısYap.Name = "btnSatısYap";
            this.btnSatısYap.Size = new System.Drawing.Size(253, 33);
            this.btnSatısYap.TabIndex = 13;
            this.btnSatısYap.Text = "Satış Yap";
            this.btnSatısYap.UseVisualStyleBackColor = true;
            this.btnSatısYap.Click += new System.EventHandler(this.btnSatısYap_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(27, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 29);
            this.label13.TabIndex = 12;
            this.label13.Text = "Kalan:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(27, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 29);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tutar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(36, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "Miktar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(27, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Miktar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(27, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // btnDolarAlis
            // 
            this.btnDolarAlis.Location = new System.Drawing.Point(306, 46);
            this.btnDolarAlis.Name = "btnDolarAlis";
            this.btnDolarAlis.Size = new System.Drawing.Size(28, 23);
            this.btnDolarAlis.TabIndex = 9;
            this.btnDolarAlis.Text = "....";
            this.btnDolarAlis.UseVisualStyleBackColor = true;
            this.btnDolarAlis.Click += new System.EventHandler(this.btnDolarAlis_Click);
            // 
            // btnDolarSatis
            // 
            this.btnDolarSatis.Location = new System.Drawing.Point(306, 91);
            this.btnDolarSatis.Name = "btnDolarSatis";
            this.btnDolarSatis.Size = new System.Drawing.Size(28, 23);
            this.btnDolarSatis.TabIndex = 10;
            this.btnDolarSatis.Text = "....";
            this.btnDolarSatis.UseVisualStyleBackColor = true;
            this.btnDolarSatis.Click += new System.EventHandler(this.btnDolarSatis_Click);
            // 
            // btnEuroAlis
            // 
            this.btnEuroAlis.Location = new System.Drawing.Point(306, 178);
            this.btnEuroAlis.Name = "btnEuroAlis";
            this.btnEuroAlis.Size = new System.Drawing.Size(28, 23);
            this.btnEuroAlis.TabIndex = 11;
            this.btnEuroAlis.Text = "....";
            this.btnEuroAlis.UseVisualStyleBackColor = true;
            this.btnEuroAlis.Click += new System.EventHandler(this.btnEuroAlis_Click);
            // 
            // btnEuroSatis
            // 
            this.btnEuroSatis.Location = new System.Drawing.Point(306, 220);
            this.btnEuroSatis.Name = "btnEuroSatis";
            this.btnEuroSatis.Size = new System.Drawing.Size(28, 23);
            this.btnEuroSatis.TabIndex = 12;
            this.btnEuroSatis.Text = "....";
            this.btnEuroSatis.UseVisualStyleBackColor = true;
            this.btnEuroSatis.Click += new System.EventHandler(this.btnEuroSatis_Click);
            // 
            // btnSatisYap2
            // 
            this.btnSatisYap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap2.Location = new System.Drawing.Point(149, 273);
            this.btnSatisYap2.Name = "btnSatisYap2";
            this.btnSatisYap2.Size = new System.Drawing.Size(253, 33);
            this.btnSatisYap2.TabIndex = 18;
            this.btnSatisYap2.Text = "Satış Yap2";
            this.btnSatisYap2.UseVisualStyleBackColor = true;
            this.btnSatisYap2.Click += new System.EventHandler(this.btnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 612);
            this.Controls.Add(this.btnEuroSatis);
            this.Controls.Add(this.btnEuroAlis);
            this.Controls.Add(this.btnDolarSatis);
            this.Controls.Add(this.btnDolarAlis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.lblDolarAlis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dövis Bürosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatısYap;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Button btnDolarAlis;
        private System.Windows.Forms.Button btnDolarSatis;
        private System.Windows.Forms.Button btnEuroAlis;
        private System.Windows.Forms.Button btnEuroSatis;
        private System.Windows.Forms.Button btnSatisYap2;
    }
}

