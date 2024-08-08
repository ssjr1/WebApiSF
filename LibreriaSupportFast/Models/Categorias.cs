using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class Categorias
    {
        public int id { get; set; }
        public string c_Categoria { get; set; }

        public int id_TecnicoDefault { get; set; }
        public Tecnicos tecnicos { get; set; }
    }
}
