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
        Task<int> crearTecnico(Tecnicos tecnico);
        Task<int> modificarTecnico(Tecnicos tecnico);
        Task<List<Tecnicos>> listadoTecnicos();
        Task eliminarTecnico(int id);
        Task<Tecnicos> obtenerTecnicoPorId(int id);
    }
}
