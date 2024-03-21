namespace StokTakipApp
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            TreeNode treeNode1 = new TreeNode("Kullanıcı Listesi");
            TreeNode treeNode2 = new TreeNode("Temel İşlemler", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Ürün Kategorileri");
            TreeNode treeNode4 = new TreeNode("Ürün Listesi");
            TreeNode treeNode5 = new TreeNode("Urunler", new TreeNode[] { treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("Yeni Müşteri");
            TreeNode treeNode7 = new TreeNode("Müşteri Listesi");
            TreeNode treeNode8 = new TreeNode("Müşteri İşlemleri", new TreeNode[] { treeNode6, treeNode7 });
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            treeView1 = new TreeView();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            tabControlEx1 = new Controls.TabControlEx();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlEx1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, hakkındaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(85, 24);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1099, 39);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 31);
            treeView1.Name = "treeView1";
            treeNode1.Name = "nodeKullanicilar";
            treeNode1.Text = "Kullanıcı Listesi";
            treeNode2.Name = "nodeTemelIslemler";
            treeNode2.Text = "Temel İşlemler";
            treeNode3.Name = "nodeKategoriler";
            treeNode3.Text = "Ürün Kategorileri";
            treeNode4.Name = "nodeUrunListesi";
            treeNode4.Text = "Ürün Listesi";
            treeNode5.Name = "nodeUrunler";
            treeNode5.Text = "Urunler";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Yeni Müşteri";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Müşteri Listesi";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Müşteri İşlemleri";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode5, treeNode8 });
            treeView1.Size = new Size(270, 457);
            treeView1.TabIndex = 3;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControlEx1);
            splitContainer1.Size = new Size(1099, 488);
            splitContainer1.SplitterDistance = 270;
            splitContainer1.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 31);
            label1.TabIndex = 4;
            label1.Text = "İŞLEM LİSTESİ";
            // 
            // tabControlEx1
            // 
            tabControlEx1.Controls.Add(tabPage3);
            tabControlEx1.Controls.Add(tabPage4);
            tabControlEx1.Dock = DockStyle.Fill;
            tabControlEx1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlEx1.Location = new Point(0, 0);
            tabControlEx1.Name = "tabControlEx1";
            tabControlEx1.Padding = new Point(12, 4);
            tabControlEx1.SelectedIndex = 0;
            tabControlEx1.Size = new Size(825, 488);
            tabControlEx1.TabIndex = 1;
            tabControlEx1.OnTabPageExClose += tabControlEx1_OnTabPageExClose;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(817, 453);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Torbalı MTAL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 31);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(817, 453);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tab";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 555);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAna";
            Text = "frmAna";
            WindowState = FormWindowState.Maximized;
            Shown += frmAna_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlEx1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private TreeView treeView1;
        private SplitContainer splitContainer1;
        private Label label1;
        private Controls.TabControlEx tabControlEx1;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}