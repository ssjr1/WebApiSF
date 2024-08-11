using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioPerfiles
    {
        Task<int> CrearPerfil(Perfiles Perfil);
        Task<int> ModificarPerfil(Perfiles Perfil);
        Task<List<Perfiles>> ListadoPerfiles();
        Task EliminarPerfil(int id);
        Task<Perfiles> ObtenerPerfilPorId(int id);
    }
}
