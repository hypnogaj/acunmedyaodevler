using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Classes;

namespace Abstraction.Abstract
{
    public class BMWAraba: Araba
    {
        public override double YakitTuketimiHesapla() { return 80.0; }
    }

}
