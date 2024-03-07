namespace StokTakipApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKaynak = new TextBox();
            txtAdres = new TextBox();
            btnGet = new Button();
            lblDurum = new Label();
            btnPost = new Button();
            txtPost = new TextBox();
            button1 = new Button();
            button2 = new Button();
            cbKategoriler = new ComboBox();
            label1 = new Label();
            btnKategorileriYenile = new Button();
            btnKategoriEkle = new Button();
            txtKategoriAd = new TextBox();
            SuspendLayout();
            // 
            // txtKaynak
            // 
            txtKaynak.Location = new Point(12, 162);
            txtKaynak.Multiline = true;
            txtKaynak.Name = "txtKaynak";
            txtKaynak.Size = new Size(1005, 403);
            txtKaynak.TabIndex = 0;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(26, 75);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(991, 23);
            txtAdres.TabIndex = 1;
            txtAdres.Text = "https://stoktakip.kurall.com/api/v1/Test";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(906, 104);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(111, 23);
            btnGet.TabIndex = 2;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(31, 110);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(38, 15);
            lblDurum.TabIndex = 3;
            lblDurum.Text = "label1";
            // 
            // btnPost
            // 
            btnPost.Location = new Point(906, 133);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(111, 23);
            btnPost.TabIndex = 4;
            btnPost.Text = "POST";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(26, 134);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(874, 23);
            txtPost.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(478, 60);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbKategoriler
            // 
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(218, 12);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(121, 23);
            cbKategoriler.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "Kategoriler";
            // 
            // btnKategorileriYenile
            // 
            btnKategorileriYenile.Location = new Point(345, 12);
            btnKategorileriYenile.Name = "btnKategorileriYenile";
            btnKategorileriYenile.Size = new Size(59, 23);
            btnKategorileriYenile.TabIndex = 10;
            btnKategorileriYenile.Text = "Yenile";
            btnKategorileriYenile.UseVisualStyleBackColor = true;
            btnKategorileriYenile.Click += btnKategorileriYenile_Click;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(345, 40);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(75, 23);
            btnKategoriEkle.TabIndex = 11;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(218, 41);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(121, 23);
            txtKategoriAd.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 577);
            Controls.Add(txtKategoriAd);
            Controls.Add(btnKategoriEkle);
            Controls.Add(btnKategorileriYenile);
            Controls.Add(label1);
            Controls.Add(cbKategoriler);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPost);
            Controls.Add(btnPost);
            Controls.Add(lblDurum);
            Controls.Add(btnGet);
            Controls.Add(txtAdres);
            Controls.Add(txtKaynak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKaynak;
        private TextBox txtAdres;
        private Button btnGet;
        private Label lblDurum;
        private Button btnPost;
        private TextBox txtPost;
        private Button button1;
        private Button button2;
        private ComboBox cbKategoriler;
        private Label label1;
        private Button btnKategorileriYenile;
        private Button btnKategoriEkle;
        private TextBox txtKategoriAd;
    }
}