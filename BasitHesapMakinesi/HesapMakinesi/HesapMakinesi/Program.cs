// See https://aka.ms/new-console-template for more information
using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi hesapMakinesi = new HesapMakinesi();
            hesapMakinesi.Hesapla();

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.Read(); 
        }
    }
}
