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
<<<<<<< HEAD

        public string C_SubCategoria { get; set; } = null;
=======
        public string C_SubCategoria { get; set; }
>>>>>>> d6b782be1246a8db7957358d11e3d8b39f923c57
    }
}
