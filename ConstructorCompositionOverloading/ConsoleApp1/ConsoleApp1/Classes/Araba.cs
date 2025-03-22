using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Araba
    {
        public Marka ArabaMarkasi { get; set; }
        public string Model { get; set; }
        public Kapi ArabaKapi { get; set; }
        public Pencere ArabaPencere { get; set; }
        public Kasa ArabaKasa { get; set; }
        public double Fiyat { get; set; }

        public Araba(Marka marka, string model, Kapi kapi, Pencere pencere, Kasa kasa, double fiyat)
        {
            ArabaMarkasi = marka;
            Model = model;
            ArabaKapi = kapi;
            ArabaPencere = pencere;
            ArabaKasa = kasa;
            Fiyat = fiyat;
        }

        public void ArabaBilgileriniGoster()
        {
            Console.WriteLine($"Arabanın markası {ArabaMarkasi.MarkaAdı}, modeli {Model}, kapı sayısı {ArabaKapi.KapiSayisi}, pencere sayısı {ArabaPencere.PencereSayisi}, kasası {ArabaKasa.KasaTipi}, fiyatı {Fiyat} TL’dir.");
        }
    }
}