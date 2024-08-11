using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioAreas
    {
        Task<int> CrearArea(Areas area);
        Task<int> ModificarArea(Areas area);
        Task<List<Areas>> ListadoAreas();
        Task EliminarArea(int id);
        Task<Areas> ObtenerAreaPorId(int id);
    }
}
