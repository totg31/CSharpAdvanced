using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening16.Data
{
    public class Lector : Persoon
    {
        public DateTime InDienst { get; set; }
        public string Afdeling { get; set; }
        public Lector()
        {

        }
        public Lector(Persoon p)
        {
            Voornaam = p.Voornaam;
            Naam = p.Naam;
            GeboorteDatum = p.GeboorteDatum;
        }
    }
}
