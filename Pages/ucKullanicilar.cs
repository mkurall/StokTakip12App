using StokTakipApp.Api;
using StokTakipApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipApp.Pages
{
    public partial class ucKullanicilar : ucTemelSayfa
    {
        public ucKullanicilar()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            colYetki.DataSource = new List<YetkiData>
            { 
                new YetkiData {Id=0,YetkiAd="Yönetici"},
                new YetkiData{Id=1,YetkiAd="Personel"}
            };

            colYetki.ValueMember = "Id";
            colYetki.DisplayMember = "YetkiAd";
            VerileriYukle();
        }

        async void VerileriYukle()
        {
            var result = await ApiV1.KullanicilariGetir();

            if(!result.HataVarMi)
            {
                dataGridView1.DataSource = result.GetData();
            }
            else
            {
                MessageBox.Show(result.HataMesaji);
            }

        }

    }
}
