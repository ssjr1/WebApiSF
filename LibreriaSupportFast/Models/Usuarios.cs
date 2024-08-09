using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string C_Cedula { get; set; }
        public string C_Nombres { get; set; }
        public string C_Apellidos { get; set; }
        public DateTime F_FecNacimiento { get; set; }
        public int Id_CodPerfil { get; set; }
        public Perfiles? Perfiles { get; set; }
        public int Id_Area { get; set; }
        public Areas? Areas { get; set; }
        public int Id_Ciudad { get; set; }
        public Ciudades? Ciudades { get; set; }
<<<<<<< HEAD
        public string C_Direcciones { get; set; }
=======
        public string C_Direccione { get; set; }
>>>>>>> d6b782be1246a8db7957358d11e3d8b39f923c57
        public DateTime F_FechaCreacion { get; set; }
        public DateTime F_FechaModificacion { get; set; }
    }
}
