using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
    public class Mudur : Calisan
    {
        public override string Pozisyon => "Müdür";
        public override double MaasinizNedir() => 60.000;
    }
}