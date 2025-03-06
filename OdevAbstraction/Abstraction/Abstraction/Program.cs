using System;
using System.Collections;
using Abstraction.Abstract;
using Abstraction.Classes;

using System;
using System.Collections;
using Abstraction.Abstract;
using Abstraction.Classes;

namespace Abstraction
    {
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Araçların Hareket Özellikleri:\n");

                Console.Write("BMW: ");
                BMW bmw = new BMW();
                bmw.KaradaGit();
                bmw.DenizdeYuz();
                bmw.HavadaUcar();

                Console.Write("Mercedes: ");
                Mercedes mercedes = new Mercedes();
                mercedes.DenizdeYuz();
                mercedes.HavadaUcar();

                Console.Write("Porsche: ");
                Porsche porsche = new Porsche();
                porsche.HavadaUcar();

                Console.WriteLine("\n");

                Console.WriteLine("Şirket Çalışanlarının Maaşları:\n");

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

                Console.WriteLine("\nAşağıdaki arabaların 1 saatlik sürüşte harcadıkları benzin miktarları verilmiştir:\n");

                BMWAraba bmwAraba = new BMWAraba();
                MercedesAraba mercedesAraba = new MercedesAraba();
                PorscheAraba porscheAraba = new PorscheAraba();

                Console.WriteLine("BMW        -> " + bmwAraba.YakitTuketimi() + " L");
                Console.WriteLine("Mercedes -> " + mercedesAraba.YakitTuketimi() + " L");
                Console.WriteLine("Porsche    -> " + porscheAraba.YakitTuketimi() + " L");

                double toplamYakit = bmwAraba.YakitTuketimi() + mercedesAraba.YakitTuketimi() + porscheAraba.YakitTuketimi();

                Console.WriteLine("\nToplam yakıt tüketimi: " + toplamYakit + " L");
            }
        }

        interface IAracHareket
        {
            void KaradaGit();
            void DenizdeYuz();
            void HavadaUcar();
        }

        class BMW : IAracHareket
        {
            public void KaradaGit() => Console.Write("Çok hızlı gider, ");
            public void DenizdeYuz() => Console.Write("denizde yüzebilir, ");
            public void HavadaUcar() => Console.WriteLine("havada uçar.");
        }

        class Mercedes : IAracHareket
        {
            public void KaradaGit() { }
            public void DenizdeYuz() => Console.Write("Denizde yüzebilir, ");
            public void HavadaUcar() => Console.WriteLine("havada uçar.");
        }

        class Porsche : IAracHareket
        {
            public void KaradaGit() { }
            public void DenizdeYuz() { }
            public void HavadaUcar() => Console.WriteLine("Havada uçar.");
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
    }