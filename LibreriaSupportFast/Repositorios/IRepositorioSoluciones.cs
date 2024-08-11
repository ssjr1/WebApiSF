using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioSoluciones
    {
        Task<int> CrearSolucion(Soluciones Solucion);
        Task<int> ModificarSolucion(Soluciones Solucion);
        Task<List<Soluciones>> ListadoSoluciones();
        Task EliminarSolucion(int id);
        Task<Soluciones> ObtenerSolucionPorId(int id);
    }
}
