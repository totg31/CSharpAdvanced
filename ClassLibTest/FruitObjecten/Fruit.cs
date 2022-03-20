using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTest.FruitObjecten
{
    public class Fruit
    {
        public int Gewicht { get; set; }
        public string Naam { get; set; }

        public string Info()
        {
            return $"Ik ben een {Naam} en ik weeg {Gewicht} gram.";
        }
        public Fruit()
        {

        }
        public Fruit(string naam, int gewicht)
        {
            Naam = naam;
            Gewicht = gewicht;
        }
        public override string ToString()
        {
            return Info();
        }
    }
}
