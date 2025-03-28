using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Araba
    {
        public Marka Marka { get; set; }
        public Model Model { get; set; }
        public double BenzinHarcamasi { get; set; }
        public double ToplamMesafe { get; set; }

        public Araba(Marka marka, Model model, double benzinHarcamasi, double toplamMesafe)
        {
            Marka = marka;
            Model = model;
            BenzinHarcamasi = benzinHarcamasi;
            ToplamMesafe = toplamMesafe;
        }

        public double Hesapla()
        {
            return (BenzinHarcamasi / 100) * ToplamMesafe;
        }

        public void Yazdir()
        {
            Console.WriteLine($"Marka: {Marka.Ad}, Model: {Model.Ad}, 100 km'de Yaktığı Yakıt: {BenzinHarcamasi} litre, Toplam Yakıt Tüketimi: {Hesapla()} litre");
        }
    }
}
