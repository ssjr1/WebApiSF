using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioCategorias
    {
<<<<<<< HEAD
        Task<int> CrearCategoria(Categorias categoria);
        Task<int> ModificarCategoria(Categorias categoria);
=======
        Task<int> CrearCategoria(Categorias categorias);
        Task<int> ModificarCategoria(Categorias categorias);
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac
        Task<List<Categorias>> ListadoCategorias();
        Task EliminarCategoria(int id);
        Task<Categorias> ObtenerCategoriaPorId(int id);
    }
}
