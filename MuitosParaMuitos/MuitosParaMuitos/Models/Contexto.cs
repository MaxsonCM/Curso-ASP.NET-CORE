using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuitosParaMuitos.Models
{
    public class Contexto : DbContext
    {

        public DbSet<Empregado> Empregados { get; set; }

        public DbSet<Trabalho> Trabalhos { get; set; }

        public DbSet<EmpregadoTrabalho> EmpregadoTrabalhos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpregadoTrabalho>().HasKey(x => new { x.EmpregadoId, x.TrabalhoId });

            modelBuilder.Entity<EmpregadoTrabalho>().HasOne(x => x.Empregado).WithMany(x => x.EmpregadoTrabalhos).HasForeignKey(x => x.EmpregadoId);

            modelBuilder.Entity<EmpregadoTrabalho>().HasOne(x => x.Trabalho).WithMany(x => x.EmpregadoTrabalhos).HasForeignKey(x => x.TrabalhoId);


        }
    }
}
