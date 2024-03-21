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
    public partial class ucUrunler : UserControl
    {
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
            
            if(!cevap.HataVarMi)
            {
                dataGridView1.DataSource = cevap.GetData();
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

    }
}
