using GerenciadorDespesas.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Models
{
    public class Contexto : DbContext
    {

        public DbSet<Mes> Meses { get; set; }
        public DbSet<Salario> Salarios { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<TipoDespesa> TipoDespesas{ get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.ApplyConfiguration(new TipoDespesasMap());
            modelBuider.ApplyConfiguration(new DespesasMap());
            modelBuider.ApplyConfiguration(new SalariosMap());
            modelBuider.ApplyConfiguration(new MesesMap());
        }
        
    }
}
