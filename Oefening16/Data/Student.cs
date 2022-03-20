using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening16.Data
{
    public class Student : Persoon
    {
        public DateTime StartDatum { get; set; }
        public string Opleiding { get; set; }
    }
}
