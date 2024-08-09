using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioSubCategorias
    {
        public class RepositorioSubCategoria : IRepositorioSubCategorias
        {
            private readonly ApplicationDbContext context;
            public RepositorioSubCategoria (ApplicationDbContext context)
            {
                this.context = context;
            }
            public async Task<int> crearSubCategoria(SubCategorias subCategorias)
            {
                context.SubCategorias.Add(subCategorias);
                await context.SaveChangesAsync();
                return subCategorias.Id;
            }
            public async Task<int> modificarSubCategorias(SubCategorias subCategorias)
            {
                SubCategorias sub = await context.SubCategorias.FindAsync(subCategorias.Id);
                sub.Id = subCategorias.Id;
                sub.C_SubCategoria = subCategorias.C_SubCategoria;
                await context.SaveChangesAsync();
                return subCategorias.Id;
            }
            public Task<List<SubCategorias>> listadoSubCategorias()
            {
                return context.SubCategorias.ToListAsync();
            }
            public async Task eliminarSubCategoria(int id)
            {
                SubCategorias subCategorias = await context.SubCategorias.FindAsync(id);
                context.SubCategorias.Remove(subCategorias);
                await context.SaveChangesAsync();
            }
            public async Task<SubCategorias> obtenerSubCategoriaPorId(int id)
            {
                return await context.SubCategorias.FindAsync(id);
            }
        }
    }
}
