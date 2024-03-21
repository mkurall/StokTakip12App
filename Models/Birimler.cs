using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp.Models
{
    public class Birimler
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public static List<Birimler> BirimListesi()
        {
            List<Birimler> liste = new List<Birimler>();
            liste.Add(new Birimler() { Id=1,Ad="Adet"});
            liste.Add(new Birimler() { Id = 2, Ad = "Gram" });
            liste.Add(new Birimler() { Id = 3, Ad = "Kg" });
            liste.Add(new Birimler() { Id = 4, Ad = "Metre" });
            liste.Add(new Birimler() { Id = 5, Ad = "Ton" });

            return liste;
        }
    }
}
