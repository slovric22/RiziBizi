using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiziBizi.Models
{
    public abstract class Narudžbe
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Sastojci { get; set; }
        public override string ToString()
        {
            return Naziv + " " + Sastojci;
        }

    }
}
