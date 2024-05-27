using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiziBizi.Models
{
    public  class Recenzija : Narudžbe
    {

        
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public string Username { get;  set; }
        public string Narudžbe {  get; set; }
    }

    }
