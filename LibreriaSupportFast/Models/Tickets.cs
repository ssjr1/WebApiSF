using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string C_Descripcion { get; set; }
        public int Id_categoria { get; set; }
        public Categorias? Categorias { get; set; }
        public int Id_SubCategoria { get; set; }
        public SubCategorias? SubCategorias { get; set; }
        public int Id_Tecnico_asignado { get; set; }
        public Tecnicos? Tecnicos { get; set; }
        public int Id_Solucion { get; set; }
        public Soluciones? Soluciones { get; set; }
        public int Id_Estado { get; set; }
        public Estados? Estados { get; set; }
        public DateTime F_Fecha_creacion { get; set; }
        public DateTime F_Fecha_Ultima_Gestion { get; set; }
        public DateTime F_Fecha_cierre { get; set; }
    }
}
