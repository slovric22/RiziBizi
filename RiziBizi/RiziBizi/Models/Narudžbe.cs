using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace RiziBizi.Models
{
    public class Narudžbe : Recenzija
    {
       
        public string Naziv { get; set; }
        public string Sastojci { get; set; }
        public string Recenzija { get; set; }
        
    }
}
