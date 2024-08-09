using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class Gestiones
    {
        public int Id { get; set; }
        public int Id_Ticket { get; set; }
        public Tickets? ticket { get; set; }
        public int Id_categoria { get; set; }
        public Categorias? Categorias { get; set; }
        public int Id_subcategoria { get; set; }
        public SubCategorias? subCategorias { get; set; }
        public int Id_tecnico_asignado { get; set; }
        public Tecnicos? tecnicos { get; set; }
        public int Id_solucion { get; set; }
        public Soluciones? Soluciones { get; set; }
        public int Id_estado { get; set; }
        public Estados? Estados { get; set; }
        public DateTime F_fecha_creacion { get; set; }
        public DateTime F_fecha_cierre { get; set; }

    }
}
