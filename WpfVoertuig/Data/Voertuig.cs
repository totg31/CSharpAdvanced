using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVoertuig.Data
{
    public class Voertuig
    {
        public int AantalWielen { get; set; }
        public string MerkNaam { get; set; }
        public string Info()
        {
            return $"Ik ben een voertuig en ik heb {AantalWielen} wielen.";
        }
    }
}
