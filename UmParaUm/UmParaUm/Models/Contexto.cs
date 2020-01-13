using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmParaUm.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }


        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasOne(x => x.Endereco).WithOne(x => x.Pessoa).HasForeignKey<Pessoa>(x => x.EnderecoId);

            modelBuilder.Entity<Endereco>().HasOne(x => x.Pessoa).WithOne(x => x.Endereco);

        }
    }
}
