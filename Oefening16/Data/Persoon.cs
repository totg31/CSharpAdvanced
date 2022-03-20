using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening16.Data
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string VolledigeNaam()
        {
            return $"{Voornaam} {Naam}";
        }
    }
}
