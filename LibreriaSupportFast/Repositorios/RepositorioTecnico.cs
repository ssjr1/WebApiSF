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
        public async Task<int> CrearTecnico(Tecnicos tecnico)
        {
            context.Tecnicos.Add(tecnico);
            await context.SaveChangesAsync();
            return tecnico.Id;
        }
        public async Task<int> ModificarTecnico(Tecnicos tecnico)
        {
            Tecnicos tec = await context.Tecnicos.FindAsync(tecnico.Id);
            tec.Id = tecnico.Id;
            tec.C_Tecnico = tecnico.C_Tecnico;
            await context.SaveChangesAsync();
            return tecnico.Id;
        }
        public Task<List<Tecnicos>> ListadoTecnicos()
        {
            return context.Tecnicos.ToListAsync();
        }
        public async Task EliminarTecnico(int id)
        {
            Tecnicos tecnicos = await context.Tecnicos.FindAsync(id);
            context.Tecnicos.Remove(tecnicos);
            await context.SaveChangesAsync();
        }
        public async Task<Tecnicos> ObtenerTecnicoPorId(int id)
        {
            return await context.Tecnicos.FindAsync(id);
        }
    }
}
