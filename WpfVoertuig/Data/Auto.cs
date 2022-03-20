using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVoertuig.Data
{
    public class Auto : Voertuig
    {
        public Auto()
        {
            AantalWielen = 4;
        }
        public string AutoInfo => $"Ik ben een auto en ik heb {AantalWielen} wielen en een merk: {MerkNaam}";
    }
}
