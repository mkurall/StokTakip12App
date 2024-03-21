namespace StokTakipApp.Pages
{
    partial class ucKullanicilar
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
            dataGridView1 = new DataGridView();
            colKullaniciAd = new DataGridViewTextBoxColumn();
            colParola = new DataGridViewTextBoxColumn();
            colYetki = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colKullaniciAd, colParola, colYetki });
            dataGridView1.Location = new Point(21, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(469, 358);
            dataGridView1.TabIndex = 0;
            // 
            // colKullaniciAd
            // 
            colKullaniciAd.DataPropertyName = "KullaniciAd";
            colKullaniciAd.HeaderText = "Kullanıcı Adı";
            colKullaniciAd.MinimumWidth = 6;
            colKullaniciAd.Name = "colKullaniciAd";
            colKullaniciAd.Width = 125;
            // 
            // colParola
            // 
            colParola.DataPropertyName = "Parola";
            colParola.HeaderText = "Parola";
            colParola.MinimumWidth = 6;
            colParola.Name = "colParola";
            colParola.Width = 125;
            // 
            // colYetki
            // 
            colYetki.DataPropertyName = "Yetki";
            colYetki.HeaderText = "Yetki";
            colYetki.MinimumWidth = 6;
            colYetki.Name = "colYetki";
            colYetki.Width = 125;
            // 
            // ucKullanicilar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "ucKullanicilar";
            Size = new Size(513, 425);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colKullaniciAd;
        private DataGridViewTextBoxColumn colParola;
        private DataGridViewComboBoxColumn colYetki;
    }
}
