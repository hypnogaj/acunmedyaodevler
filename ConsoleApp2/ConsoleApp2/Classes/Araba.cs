using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{

    public class Araba
    {
        public string marka;
        public string vitesTuru;


        public void Git(string marka, string vitesTuru)
        {
            Console.WriteLine(marka  + "" + vitesTuru);
        }

        public void MarkaVitesTuruYaz(string markasi, string vitesTuru)
        {
            Console.WriteLine("" + markasi  + "" +  vitesTuru);
        }
    }
}