using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiziBizi.Models
{
    public abstract class Recenzija : Narudžbe
    {
        public int Ocjena { get; set; }
        public string Komentar {  get; set; }
    }
}
