using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class Gestiones
    {
        public int id { get; set; }
        public int id_Ticket { get; set; }
        public Tickets ticket { get; set; }
        public int id_categoria { get; set; }
        public Categorias categorias { get; set; }
        public int id_subcategoria { get; set; }
        public SubCategorias subCategorias { get; set; }
        public int id_tecnico_asignado { get; set; }
        public Tecnicos tecnicos { get; set; }
        public int id_solucion { get; set; }
        public Soluciones soluciones { get; set; }
        public int id_estado { get; set; }
        public Estados estados { get; set; }
        public DateTime f_fecha_creacion { get; set; }
        public DateTime f_fecha_cierre { get; set; }

    }
}
