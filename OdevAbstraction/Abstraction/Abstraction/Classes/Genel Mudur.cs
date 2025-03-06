using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    public class GenelMudur : Calisan
    {
        public override string Pozisyon => "Genel Müdür";
        public override double MaasinizNedir() => 80.000;
    }
}

