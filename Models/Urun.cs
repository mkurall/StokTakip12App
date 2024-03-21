using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Models
{
    public class Urun
    {
        public int UrunId { get; set; }

        public string UrunKodu { get; set; } = null!;

        public int KategoriId { get; set; }

        public string UrunAd { get; set; } = null!;

        public int BirimId { get; set; }

        public string? UrunAciklama { get; set; }

        public double? MinStok { get; set; }

        public double? MaksStok { get; set; }
    }
}
