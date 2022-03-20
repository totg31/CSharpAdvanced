using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTest.TellerObjecten
{
    public class Teller
    {
        private int counter;
        public int Counter { get; }
        public Teller()
        {
            counter = 0;
        }

        public void ResetTeller()
        {
            counter = 0;
        }
        public void VerhoogTeller()
        {
            counter++;
        }
        public void VerminderTeller()
        {
            counter--;
        }
        public int Waarde(int nummer)
        {
            return counter + nummer;
        }
    }
}
