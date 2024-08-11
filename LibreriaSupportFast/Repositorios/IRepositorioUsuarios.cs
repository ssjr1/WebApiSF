using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioUsuarios
    {
        Task<int> CrearUsuario(Usuarios Usuario);
        Task<int> ModificarUsuario(Usuarios Usuario);
        Task<List<Usuarios>> ListadoUsuarios();
        Task EliminarUsuario(int id);
        Task<Usuarios> ObtenerUsuarioPorId(int id);
    }
}
