namespace StokTakipApp.Pages
{
    partial class ucUrunler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            colUrunKodu = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewComboBoxColumn();
            colUrunAd = new DataGridViewTextBoxColumn();
            colBirim = new DataGridViewComboBoxColumn();
            colAciklama = new DataGridViewTextBoxColumn();
            colMinStok = new DataGridViewTextBoxColumn();
            colMaksStok = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "0 Adet Ürün ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colUrunKodu, colKategori, colUrunAd, colBirim, colAciklama, colMinStok, colMaksStok });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1179, 340);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 46);
            panel1.TabIndex = 2;
            // 
            // colUrunKodu
            // 
            colUrunKodu.DataPropertyName = "UrunKodu";
            colUrunKodu.HeaderText = "Urun Kodu";
            colUrunKodu.MinimumWidth = 6;
            colUrunKodu.Name = "colUrunKodu";
            colUrunKodu.Width = 125;
            // 
            // colKategori
            // 
            colKategori.DataPropertyName = "KategoriId";
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.Width = 125;
            // 
            // colUrunAd
            // 
            colUrunAd.DataPropertyName = "UrunAd";
            colUrunAd.HeaderText = "Ürün Adı";
            colUrunAd.MinimumWidth = 6;
            colUrunAd.Name = "colUrunAd";
            colUrunAd.Width = 125;
            // 
            // colBirim
            // 
            colBirim.DataPropertyName = "BirimId";
            colBirim.HeaderText = "Birim";
            colBirim.MinimumWidth = 6;
            colBirim.Name = "colBirim";
            colBirim.Width = 125;
            // 
            // colAciklama
            // 
            colAciklama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAciklama.DataPropertyName = "UrunAciklama";
            colAciklama.HeaderText = "Açıklama";
            colAciklama.MinimumWidth = 6;
            colAciklama.Name = "colAciklama";
            // 
            // colMinStok
            // 
            colMinStok.DataPropertyName = "MinStok";
            colMinStok.HeaderText = "MinStok";
            colMinStok.MinimumWidth = 6;
            colMinStok.Name = "colMinStok";
            colMinStok.Width = 125;
            // 
            // colMaksStok
            // 
            colMaksStok.DataPropertyName = "MaksStok";
            colMaksStok.HeaderText = "MaksStok";
            colMaksStok.MinimumWidth = 6;
            colMaksStok.Name = "colMaksStok";
            colMaksStok.Width = 125;
            // 
            // ucUrunler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ucUrunler";
            Size = new Size(1179, 386);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn colUrunKodu;
        private DataGridViewComboBoxColumn colKategori;
        private DataGridViewTextBoxColumn colUrunAd;
        private DataGridViewComboBoxColumn colBirim;
        private DataGridViewTextBoxColumn colAciklama;
        private DataGridViewTextBoxColumn colMinStok;
        private DataGridViewTextBoxColumn colMaksStok;
    }
}
