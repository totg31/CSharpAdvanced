using System;
using System.Collections.Generic;
using System.Text;

namespace Toepassing07
{
    class Bankrekening
    {
        public decimal HuidigeSaldo { get; set; }
        public Bankrekening()
        {
            HuidigeSaldo = 0;
        }
        public void OpnameBedrag(decimal bedrag)
        {
            HuidigeSaldo += bedrag;
        }
        public void Storting(decimal bedrag)
        {
            HuidigeSaldo += bedrag;
        }
    }
}
