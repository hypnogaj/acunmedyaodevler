using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConditionAssignment.CalisanMaasHesapla
{
    public abstract class Calisan
    {
        public abstract string Pozisyon { get; }
        public abstract double MaasinizNedir();
    }
}