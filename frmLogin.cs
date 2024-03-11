using StokTakipApp.Api;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblBilgi.Text = "";
        }

        private async void btnOturumAc_Click(object sender, EventArgs e)
        {
            pbMesgul.Visible = true;
            lblBilgi.Text = "";

            ApiCevap cevap = await ApiV1.Login(txtKullaniciAd.Text, txtParola.Text);

            pbMesgul.Visible = false;

            if(cevap.BasariliMi)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblBilgi.Text = cevap.HataMesaji;
            }
        }
    }
}
