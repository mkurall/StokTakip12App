using Newtonsoft.Json;
using StokTakipApp.Api;
using StokTakipApp.Models;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StokTakipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("Test");
            txtKaynak.Text = await resp.Content.ReadAsStringAsync();

        }

        private async void btnPost_Click(object sender, EventArgs e)
        {




        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ApiCevap cevap = await ApiV1.Login("admin", "1234");
            HttpUtils.SetToken(cevap.Data.ToString());

        }

        private async void btnKategorileriYenile_Click(object sender, EventArgs e)
        {


            var l = await ApiV1.KategorileriGetir();

            cbKategoriler.DataSource = l.GetData();
            cbKategoriler.DisplayMember = "KategoriAdi";
            cbKategoriler.ValueMember = "KategaoriId";
        }

        private async void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            ApiCevapData<Kategori> res = await ApiV1.KategoriEkle(txtKategoriAd.Text);

            if(res.HataVarMi)
            {
                MessageBox.Show(res.HataMesaji);
            }
            else
            {
                MessageBox.Show("Kategori Eklendi");
            }
        }
    }
}