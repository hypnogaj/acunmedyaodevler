using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    public class Mercedes : IHareket
    {
        public void KaradaGit()
        {

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