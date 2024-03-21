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
    public partial class ucKategoriler : UserControl
    {
        BindingList<Kategori> liste = new BindingList<Kategori>();
        public ucKategoriler()
        {
            InitializeComponent();


            VerileriYukle();
        }

        async void VerileriYukle()
        {
            var cevap = await ApiV1.KategorileriGetir();

            if (!cevap.HataVarMi)
            {
                liste = new BindingList<Kategori>(cevap.GetData());

                listBox1.DataSource = liste;
                listBox1.DisplayMember = "KategoriAdi";
                listBox1.ValueMember = "KategaoriId";
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var cevap = await ApiV1.KategoriEkle(txtKategoriAdi.Text);
            liste.Add(cevap.GetData());

        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)listBox1.SelectedValue;
            Kategori kategori = liste.FirstOrDefault(x => x.KategaoriId == id);

            var cevap = await ApiV1.KategoriSil(id);

            if(!cevap.HataVarMi)
                liste.Remove(kategori);
        }
    }
}
