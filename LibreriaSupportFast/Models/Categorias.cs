using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        public string C_Categoria { get; set; }

        public int Id_TecnicoDefault { get; set; }
<<<<<<< HEAD
        public Tecnicos? Tecnicos { get; set; }
=======
        public Tecnicos Tecnicos { get; set; }
>>>>>>> 4cd01abcffdf20eca6f77cc7255f8afb7b58318f
    }
}
