using LibreriaSupportFast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioSubCategorias
    {
        Task<int> crearSubCategoria(SubCategorias subCategorias);
        Task<int> modificarSubCategorias(SubCategorias subCategorias);
        Task<List<SubCategorias>> listadoSubCategorias();
        Task eliminarSubCategoria(int id);
        Task<Tecnicos> obtenerSubCategoriaPorId(int id);
    }
}
