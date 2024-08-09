using LibreriaSupportFast.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioCategorias
    {
        Task<int> CrearCategoria(Categorias categorias);
        Task<int> ModificarCategoria(Categorias categorias);
        Task<List<Categorias>> ListadoCategorias();
        Task EliminarCategoria(int id);
        Task<Categorias> ObtenerCategoriaPorId(int id);
    }
}
