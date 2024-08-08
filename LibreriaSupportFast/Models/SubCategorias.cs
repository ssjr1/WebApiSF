using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class SubCategorias
    {
        public int id { get; set; }
        public int id_Categoria { get; set; }
        public Categorias categorias { get; set; }

        public string c_SubCategoria { get; set; }
    }
}
