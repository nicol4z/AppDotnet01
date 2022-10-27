using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppDotnet01
{
    internal class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-COE92JK8;Database=dbDotnet;Trusted_Connection=True");
        }

        public DbSet<Proyecto> Proyectos { get; set; }

        public DbSet<Tarea> Tareas { get; set; }

        public DbSet<Material> Materiales { get; set; }

        public DbSet<ConsumoMaterial> ConsumoMateriales { get; set; }
    }
}
