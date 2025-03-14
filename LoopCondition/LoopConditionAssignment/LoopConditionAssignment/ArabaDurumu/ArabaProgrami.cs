using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditionAssignment.ArabaDurumu
{
   public class ArabaProgrami
   {
        public static void ArabaSorgula()
        { 
            Console.Write("Arabanızın yaşını girin: ");
            int arabaYasi = Convert.ToInt32(Console.ReadLine());

            string sonuc = ArabaDurumu(arabaYasi);
            Console.WriteLine(sonuc);
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
}

       

      