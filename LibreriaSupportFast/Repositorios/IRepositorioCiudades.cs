using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioCiudades
    {
        Task<int> CrearCiudad(Ciudades ciudad);
        Task<int> ModificarCiudad(Ciudades ciudad);
        Task<List<Ciudades>> ListadoCiudades();
        Task EliminarCiudad(int id);
        Task<Ciudades> ObtenerCiudadPorId(int id);
    }
}
