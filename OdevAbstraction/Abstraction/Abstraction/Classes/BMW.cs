using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    public class BMW : IHareket
    {
        public void KaradaGit()
        {
            Console.Write("Çok hızlı gider, ");
        }

        public void DenizdeYuz()
        {
            Console.Write("denizde yüzebilir, ");
        }

        public void HavadaUcar()
        {
            Console.WriteLine("havada uçar.");
        }
    }
}