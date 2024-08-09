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
<<<<<<< HEAD
        public Categorias? Categorias { get; set; }

        public string C_SubCategoria { get; set; } = null;
=======
        public Categorias Categorias { get; set; }
        public string C_SubCategoria { get; set; }
>>>>>>> 4cd01abcffdf20eca6f77cc7255f8afb7b58318f
    }
}
