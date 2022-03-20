using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVoertuig.Data
{
    public class Fiets : Voertuig
    {
        public Fiets(string merkNaam)
        {
            merkNaam = MerkNaam;
            AantalWielen = 2;
        }
        public string FietsInfo => $"Ik ben een fiets en ik heb {AantalWielen} wielen en een merk: {MerkNaam}";
    }
}
