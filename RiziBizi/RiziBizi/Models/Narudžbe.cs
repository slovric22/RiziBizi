using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DBLayer;

namespace RiziBizi.Models
{
    public class Narudžbe : object
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Sastojci { get; set; }
        public string Recenzija { get; set; }
        public override string ToString()
        {
            return Naziv;

        }
    }
}
