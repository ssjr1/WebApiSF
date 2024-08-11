using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioEstados
    {
        Task<int> CrearEstado(Estados Estado);
        Task<int> ModificarEstado(Estados Estado);
        Task<List<Estados>> ListadoEstados();
        Task EliminarEstado(int id);
        Task<Estados> ObtenerEstadoPorId(int id);
    }
}
