using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    public class Araba
    {
        public string marka;
        public string AraclarınHareketOzellikleri;


        public void Git(string marka, string AraclarınHareketOzellikleri)
        {
            Console.WriteLine(marka + "" + AraclarınHareketOzellikleri);
        }

        public void MarkaAraclarınHareketOzellikleri(string markasi, string AraclarınHareketOzellikleri)
        {
            Console.WriteLine("" + markasi + ":" + AraclarınHareketOzellikleri);
        }
    }
}