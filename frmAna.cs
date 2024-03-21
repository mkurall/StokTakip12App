using StokTakipApp.Api;
using StokTakipApp.Controls;
using StokTakipApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipApp
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Shown(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();

            if (form.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

        }

        UserControl SayfaOlustur(TreeNode node)
        {
            if (node.Name == "nodeKullanicilar")
                return new ucKullanicilar();
            else if (node.Name == "nodeKategoriler")
                return new ucKategoriler();
            else if(node.Name == "nodeUrunListesi")
                return new ucUrunler();

            return null;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UserControl uc = SayfaOlustur(e.Node);
            if (uc == null)
                return;

            TabPageEx tabPage = new TabPageEx();
            tabPage.Text = e.Node.Text;



            uc.Dock = DockStyle.Fill;

            tabPage.Controls.Add(uc);

            tabControlEx1.TabPages.Add(tabPage);
            tabControlEx1.SelectedTab = tabPage;
        }

        private void tabControlEx1_OnTabPageExClose(object sender, int tabIndex)
        {
            //MessageBox.Show(tabIndex + ".tabPage kapatılacak!");
            tabControlEx1.TabPages.RemoveAt(tabIndex);
        }
    }
}
