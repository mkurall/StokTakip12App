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
    public partial class ucUrunler : ucTemelSayfa
    {
        BindingList<Urun> bindList = null;

        public ucUrunler()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            BirimleriYukle();
            KategorileriYukle();
            UrunleriYukle();
        }

        async void UrunleriYukle()
        {
            var cevap = await ApiV1.UrunleriGetir();

            if (!cevap.HataVarMi)
            {
                bindList = new BindingList<Urun>(cevap.GetData());
                dataGridView1.DataSource = bindList;
            }
            else
            {
                MessageBox.Show(cevap.HataMesaji);
            }

        }

        async void KategorileriYukle()
        {
            var cevap = await ApiV1.KategorileriGetir();

            if (!cevap.HataVarMi)
            {
                colKategori.DataSource = cevap.GetData();
                colKategori.DisplayMember = "KategoriAdi";
                colKategori.ValueMember = "KategaoriId";
            }
            else
            {
                MessageBox.Show(cevap.HataMesaji);
            }
        }

        void BirimleriYukle()
        {
            colBirim.DataSource = Birimler.BirimListesi();
            colBirim.DisplayMember = "Ad";
            colBirim.ValueMember = "Id";
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        public async override void Kaydet()
        {
            foreach (var item in bindList)
            {
                if(item.UrunId == 0)
                {
                    var cevap = await ApiV1.UrunEkle(item.UrunKodu, item.UrunAd, item.KategoriId, item.BirimId, item.UrunAciklama);

                    if(!cevap.HataVarMi)
                    {
                        Urun urun = cevap.GetData();
                        item.UrunId = urun.UrunId;
                    }

                }
            }
        }
    }
}
