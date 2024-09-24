using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistenciaSport.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AsistenciaSport.BD.Data
{
    public class Context(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Administrador> Administradores => Set<Administrador>();
        public DbSet<Asistencias> Asistencia => Set<Asistencias>();
        public DbSet<Cuotas> Cuotas => Set<Cuotas>();
        public DbSet<Miembro> Miembros => Set<Miembro>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.G­etEntityTypes()
                                          .SelectMany(t => t.GetForeignKeys())
                                          .Where(fk => !fk.IsOwnership
                                                       && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}