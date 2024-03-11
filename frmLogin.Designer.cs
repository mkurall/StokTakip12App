namespace StokTakipApp
{
    partial class frmLogin
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
            label1 = new Label();
            txtKullaniciAd = new TextBox();
            label2 = new Label();
            txtParola = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnOturumAc = new Button();
            lblBilgi = new Label();
            pbMesgul = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMesgul).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 72);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(128, 71);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(260, 27);
            txtKullaniciAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 104);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Parola";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(128, 104);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '●';
            txtParola.Size = new Size(260, 27);
            txtParola.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 52);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.cyber_security;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 5);
            label3.Name = "label3";
            label3.Size = new Size(220, 41);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Girişi";
            // 
            // btnOturumAc
            // 
            btnOturumAc.BackColor = Color.LightBlue;
            btnOturumAc.Location = new Point(236, 4);
            btnOturumAc.Name = "btnOturumAc";
            btnOturumAc.Size = new Size(152, 39);
            btnOturumAc.TabIndex = 3;
            btnOturumAc.Text = "Oturum Aç";
            btnOturumAc.UseVisualStyleBackColor = false;
            btnOturumAc.Click += btnOturumAc_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBilgi.ForeColor = Color.OrangeRed;
            lblBilgi.Location = new Point(0, 128);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(398, 25);
            lblBilgi.TabIndex = 4;
            lblBilgi.Text = "label4";
            lblBilgi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbMesgul
            // 
            pbMesgul.Image = Properties.Resources.mesgul;
            pbMesgul.Location = new Point(12, 8);
            pbMesgul.Name = "pbMesgul";
            pbMesgul.Size = new Size(35, 32);
            pbMesgul.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMesgul.TabIndex = 5;
            pbMesgul.TabStop = false;
            pbMesgul.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbMesgul);
            panel2.Controls.Add(btnOturumAc);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 49);
            panel2.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 207);
            Controls.Add(panel2);
            Controls.Add(lblBilgi);
            Controls.Add(panel1);
            Controls.Add(txtParola);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMesgul).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAd;
        private Label label2;
        private TextBox txtParola;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnOturumAc;
        private Label lblBilgi;
        private PictureBox pbMesgul;
        private Panel panel2;
    }
}