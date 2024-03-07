using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Models
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }

        public string KullaniciAd { get; set; }

        public string Parola { get; set; }

        public int? Yetki { get; set; }
    }
}
