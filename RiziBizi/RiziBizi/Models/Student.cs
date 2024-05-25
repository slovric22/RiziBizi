using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiziBizi.Models
{
    public abstract class Student : Narudžbe
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
