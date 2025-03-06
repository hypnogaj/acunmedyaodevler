using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    public class Programci : Calisan
    {
        public override string Pozisyon => "Programcı";  // Pozisyon adı
        public override double MaasinizNedir() => 40.000;  // Maaş bilgisi
    }
}