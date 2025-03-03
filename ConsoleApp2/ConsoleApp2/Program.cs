// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Classes;
using System.Text;
namespace ConsoleApp2
{
    using System;
    using System.Text;

    namespace ConsoleApp2
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Konsolun karakter kodlamasını UTF-8 olarak ayarla
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;

              
                Araba BMW = new BMW();
                Araba Porsche = new Porsche();
                Araba Mercedes = new Mercedes();
                Araba Togg = new Togg();
                Araba Audi = new Audi();
                Araba Toyota = new Toyota();

              
                BMW bm = new BMW();
                bm.MarkaVitesTuruYaz("BMW", "→ Düz viteslidir.");

                Mercedes me = new Mercedes();
                me.MarkaVitesTuruYaz("Mercedes", "→ Otomatik viteslidir.");

                Porsche p = new Porsche();
                p.MarkaVitesTuruYaz("Porsche", "→ Otomatik viteslidir.");

                Audi a = new Audi();
                a.MarkaVitesTuruYaz("Audi", "→ Düz viteslidir.");

                Togg t = new Togg();
                t.MarkaVitesTuruYaz("Togg", "→ Otomatik viteslidir.");

                Toyota to = new Toyota();
                to.MarkaVitesTuruYaz("Toyota", "→ Düz viteslidir.");




            }
        }
    }
}




