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
<<<<<<< HEAD
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
=======
        public Tickets? Ticket { get; set; }
        public int Id_Categoria { get; set; }
        public Categorias? Categorias { get; set; }
        public int Id_SubCategoria { get; set; }
        public SubCategorias? SubCategorias { get; set; }
        public int Id_tecnico_asignado { get; set; }
        public Tecnicos? Tecnicos { get; set; }
        public int Id_Solucion { get; set; }
        public Soluciones? Soluciones { get; set; }
        public int Id_Estado { get; set; }
        public Estados? Estados { get; set; }
        public DateTime F_Fecha_creacion { get; set; }
        public DateTime F_Fecha_cierre { get; set; }
>>>>>>> d6b782be1246a8db7957358d11e3d8b39f923c57

    }
}
