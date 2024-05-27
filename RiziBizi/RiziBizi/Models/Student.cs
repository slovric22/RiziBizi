using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace RiziBizi.Models
{

    public class Student : Narudžbe
    
    {
        public string Ime { get; set; }
        public string Lozinka { get; set; }
    }

    
}
