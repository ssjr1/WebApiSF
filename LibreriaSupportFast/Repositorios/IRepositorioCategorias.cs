using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioCategorias
    {
        Task<int> CrearCategoria(Categorias categoria);
        Task<int> ModificarCategoria(Categorias categoria);
        Task<List<Categorias>> ListadoCategorias();
        Task EliminarCategoria(int id);
        Task<Categorias> ObtenerCategoriaPorId(int id);
    }
}
