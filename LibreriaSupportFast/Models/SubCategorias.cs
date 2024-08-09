using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class SubCategorias
    {
        public int Id { get; set; }
        public int Id_Categoria { get; set; }
        public Categorias? Categorias { get; set; }
        public string C_SubCategoria { get; set; }
    }
}
