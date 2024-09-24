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
        public DbSet<Miembro> Miembros => Set<Miembro>();
        public DbSet<Asistencias> Asistencia => Set<Asistencias>();
        public DbSet<Cuotas> Cuotas => Set<Cuotas>();
    }
}