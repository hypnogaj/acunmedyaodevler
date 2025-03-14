using System;

using System;

class Program
{
    static void Main()
    {
        
        YasProgrami.YasSorgula();

       
        ArabaProgrami.ArabaSorgula();

        
        ArabaBenzinTuketimi();

       
        CalisanMaaslariGoster();
    }

    #region Yaş Kategorisi
    class YasProgrami
    {
        public static void YasSorgula()
        {
            Console.Write("Yaşınızı girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            string sonuc = YasKategorisi(yas);
            Console.WriteLine("Yaş Kategoriniz: " + sonuc);
        }

        public static string YasKategorisi(int yas)
        {
            if (yas < 0 || yas > 99)
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            else if (yas < 18)
                return "Küçüksünüz";
            else if (yas < 35)
                return "Gençsiniz";
            else if (yas < 55)
                return "Yetişkinsiniz";
            else if (yas < 75)
                return "Yaşlısınız";
            else
                return "Çok yaşlısınız";
        }
    }
    #endregion

    #region Araba Durumu
    class ArabaProgrami
    {
        public static void ArabaSorgula()
        {
            Console.Write("Arabanızın yaşını girin: ");
            int arabaYasi = Convert.ToInt32(Console.ReadLine());

            string sonuc = ArabaDurumu(arabaYasi);
            Console.WriteLine("Araba Durumu: " + sonuc);
        }

        public static string ArabaDurumu(int yas)
        {
            if (yas < 0 || yas > 30)
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            else if (yas < 10)
                return "Arabanız yeni";
            else if (yas < 20)
                return "Servise götürmeniz gerekebilir";
            else
                return "Arabanız hurdaya çıkabilir";
        }
    }
    #endregion

    #region Araba Benzin Tüketimi
    static void ArabaBenzinTuketimi()
    {
        Console.WriteLine("\nAşağıdaki arabaların 1 saatlik sürüşte harcadıkları benzin miktarları verilmiştir:\n");

        BMWAraba bmwAraba = new BMWAraba();
        MercedesAraba mercedesAraba = new MercedesAraba();
        PorscheAraba porscheAraba = new PorscheAraba();

        Console.WriteLine("BMW        -> " + bmwAraba.YakitTuketimi() + " L");
        Console.WriteLine("Mercedes   -> " + mercedesAraba.YakitTuketimi() + " L");
        Console.WriteLine("Porsche    -> " + porscheAraba.YakitTuketimi() + " L");

        double toplamYakit = bmwAraba.YakitTuketimi() + mercedesAraba.YakitTuketimi() + porscheAraba.YakitTuketimi();

        Console.WriteLine("\nToplam yakıt tüketimi: " + toplamYakit + " L");
    }
    #endregion

    #region Çalışan Maaşları
    static void CalisanMaaslariGoster()
    {
        Console.WriteLine("\nŞirket Çalışanlarının Maaşları:\n");

        GenelMudur gm = new GenelMudur();
        Mudur mu = new Mudur();
        Programci pr = new Programci();
        Stajyer s = new Stajyer();

        double toplamMaas = 0.0;

        Console.WriteLine("Genel Müdür -> " + gm.MaasinizNedir() + " TL");
        Console.WriteLine("Müdür -> " + mu.MaasinizNedir() + " TL");
        Console.WriteLine("Programcı -> " + pr.MaasinizNedir() + " TL");
        Console.WriteLine("Stajyer -> " + s.MaasinizNedir() + " TL");

        toplamMaas += gm.MaasinizNedir();
        toplamMaas += mu.MaasinizNedir();
        toplamMaas += pr.MaasinizNedir();
        toplamMaas += s.MaasinizNedir();

        Console.WriteLine("\nToplam : " + toplamMaas + " TL maaş alıyorlar");
    }

    abstract class Calisan
    {
        public abstract double MaasinizNedir();
    }

    class GenelMudur : Calisan
    {
        public override double MaasinizNedir() => 80000;
    }

    class Mudur : Calisan
    {
        public override double MaasinizNedir() => 60000;
    }

    class Programci : Calisan
    {
        public override double MaasinizNedir() => 40000;
    }

    class Stajyer : Calisan
    {
        public override double MaasinizNedir() => 5000;
    }
    #endregion

    #region Araba Benzin Tüketimi (Interface)
    interface IYakitTuketimi
    {
        double YakitTuketimi();
    }

    abstract class Araba : IYakitTuketimi
    {
        public abstract double YakitTuketimi();
    }

    class BMWAraba : Araba
    {
        public override double YakitTuketimi() => 80.0;
    }

    class MercedesAraba : Araba
    {
        public override double YakitTuketimi() => 70.0;
    }

    class PorscheAraba : Araba
    {
        public override double YakitTuketimi() => 60.0;
    }
    #endregion
}
