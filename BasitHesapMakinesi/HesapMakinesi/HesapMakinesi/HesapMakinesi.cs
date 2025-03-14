using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    public class HesapMakinesi
    {
        public void Hesapla()
        {
            Console.WriteLine("İşlemi Seçiniz (/,*,+,-)");
            string islem = Console.ReadLine();
            Console.Write("Sayı1 : ");
            string sayi1 = Console.ReadLine();
            Console.Write("Sayı2 : ");
            string sayi2 = Console.ReadLine();
            while (int.TryParse(sayi1, out int a) && int.TryParse(sayi2, out int b))
            {
                if (islem == "-")
                {
                    Console.WriteLine(Cikar(a, b));
                }
                else if (islem == "+")
                {
                    Console.WriteLine(Topla(a, b));
                }
                else if (islem == "*")
                {
                    Console.WriteLine(Carp(a, b));
                }
                else if (islem == "/")
                {
                    Console.WriteLine(Bol(a, b));
                }
                else if (islem == "0")
                {
                    Console.WriteLine("Hesap Makinesinden çıkılıyor.");

                }
                else
                {
                    Environment.Exit(0);
                }
            }


        }
    public int Topla(int sayi1, int sayi2)
    {
        return sayi2 + sayi1;
    }

    public int Carp(int sayi1, int sayi2)
    {
        return sayi2 * sayi1;
    }

    public int Bol(int sayi1, int sayi2)
    {
        return sayi1 / sayi2;
    }

    public int Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}
}

 