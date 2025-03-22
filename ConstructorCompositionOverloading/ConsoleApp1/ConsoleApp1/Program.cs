using System;
using ConsoleApp1.Classes;

class Program;

public class Kapi
{
    public int KapiSayisi { get; set; }

    public Kapi(int kapiSayisi)
    {
        KapiSayisi = kapiSayisi;
    }
}

public class Pencere
{
    public int PencereSayisi { get; set; }

    public Pencere(int pencereSayisi)
    {
        PencereSayisi = pencereSayisi;
    }
}

public class Kasa
{
    public string KasaTipi { get; set; }

    public Kasa(string kasaTipi)
    {
        KasaTipi = kasaTipi;
    }
}

public class Marka
{
    public string MarkaAdı { get; set; }

    public Marka(string markaAdı)
    {
        MarkaAdı = markaAdı;
    }
}

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

public class Matematik
{
   
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

   
    public int Topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }

  
    public double Topla(double sayi1, double sayi2)
    {
        return sayi1 + sayi2;
    }

   
    public double Topla(double sayi1, double sayi2, double sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }

    
    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

   
    public int Carp(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 * sayi2 * sayi3;
    }

    
    public double Carp(double sayi1, double sayi2)
    {
        return sayi1 * sayi2;
    }

    
    public double Carp(double sayi1, double sayi2, double sayi3)
    {
        return sayi1 * sayi2 * sayi3;
    }

   
    public double Topla(int sayi1, double sayi2)
    {
        return sayi1 + sayi2;
    }

    
    public double Carp(int sayi1, double sayi2)
    {
        return sayi1 * sayi2;
    }
}



namespace ConsoleApp1.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            Marka bmw = new Marka("BMW");
            Kapi kapi = new Kapi(4);
            Pencere pencere = new Pencere(4);
            Kasa kasa = new Kasa("sedan");

            Araba bmwX5 = new Araba(bmw, "X5", kapi, pencere, kasa, 2000000);
            bmwX5.ArabaBilgileriniGoster();

            Matematik matematik = new Matematik();

         
            int sayi1 = 5;
            int sayi2 = 10;
            int sayi3 = 15;

            double sayi4 = 5.5;
            double sayi5 = 10.5;
            double sayi6 = 15.5;

           
            Console.WriteLine("Toplama (int, 2 parametre): " + matematik.Topla(sayi1, sayi2));
            Console.WriteLine("Toplama (int, 3 parametre): " + matematik.Topla(sayi1, sayi2, sayi3));

            Console.WriteLine("Toplama (double, 2 parametre): " + matematik.Topla(sayi4, sayi5));
            Console.WriteLine("Toplama (double, 3 parametre): " + matematik.Topla(sayi4, sayi5, sayi6));

            
            Console.WriteLine("Çarpma (int, 2 parametre): " + matematik.Carp(sayi1, sayi2));
            Console.WriteLine("Çarpma (int, 3 parametre): " + matematik.Carp(sayi1, sayi2, sayi3));

            Console.WriteLine("Çarpma (double, 2 parametre): " + matematik.Carp(sayi4, sayi5));
            Console.WriteLine("Çarpma (double, 3 parametre): " + matematik.Carp(sayi4, sayi5, sayi6));

            
            Console.WriteLine("Toplama (int + double): " + matematik.Topla(sayi1, sayi4));
            Console.WriteLine("Çarpma (int * double): " + matematik.Carp(sayi1, sayi4));
        }
    }
}

