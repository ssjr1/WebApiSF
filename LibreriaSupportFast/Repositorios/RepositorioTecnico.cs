using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
        private readonly ApplicationDbContext context;
        public RepositorioTecnico(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<int> crearTecnico(Tecnicos tecnico)
        {
            context.Tecnicos.Add(tecnico);
            await context.SaveChangesAsync();
            return Tecnicos.id;
        }
        public async Task<int> modificarTecnico(Tecnicos tecnico)
        {
            Tecnicos tec = await context.Tecnicos.FindAsync(tecnico.id);
            tec.id = tecnico.id;
            tec.c_Tecnico = tecnico.c_Tecnico;
            await context.SaveChangesAsync();
            return tecnico.id;
        }
        public Task<List<Tecnicos>> listadoTecnicos()
        {
            return context.Tecnicos.ToListAsync();
        }
        async Task eliminarTecnico(int id)
        {
            Tecnicos tecnicos = await context.Tecnicos.FindAsync(id);
            context.Tecnicos.Remove(tecnicos);
            await context.SaveChangesAsync();
        }
        public async Task<Tecnicos> obtenerTecnicoPorId(int id)
        {
            return await context.Tecnicos.FindAsync(id);
        }
    }
}
