using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioGestiones
    {
        Task<int> CrearGestion(Gestiones gestion);
        Task<int> ModificarGestion(Gestiones gestion);
        Task<List<Gestiones>> ListadoGestiones();
        Task EliminarGestion(int id);
        Task<Gestiones> ObtenerGestionPorId(int id);
    }
}

