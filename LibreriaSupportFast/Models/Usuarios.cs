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
        public string c_Cedula { get; set; }
        public string c_Nombres { get; set; }
        public string c_Apellidos { get; set; }
        public DateTime f_FecNacimiento { get; set; }
        public int id_CodPerfil { get; set; }
        public Perfiles perfiles { get; set; }
        public int id_Area { get; set; }
        public Areas areas { get; set; }
        public int id_Ciudad { get; set; }
        public Ciudades ciudades { get; set; }
        public string c_Direccione { get; set; }
        public DateTime f_FechaCreacion { get; set; }
        public DateTime f_FechaModificacion { get; set; }
    }
}
