using LibreriaSupportFast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioTecnico
    {
        Task<int> CrearTecnico(Tecnicos tecnico);
        Task<int> ModificarTecnico(Tecnicos tecnico);
        Task<List<Tecnicos>> ListadoTecnicos();
        Task EliminarTecnico(int id);
        Task<Tecnicos> ObtenerTecnicoPorId(int id);
    }
}
