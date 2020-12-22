using Microsoft.EntityFrameworkCore;
using MontagemCurriculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Mapeamento
{
    public class TipoCursoMap : IEntityTypeConfiguration<TipoCurso>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TipoCurso> builder)
        {
            builder.HasKey(tc => tc.TipoCursoId);

            builder.Property(tc => tc.Tipo).IsRequired();
            builder.HasIndex(tc => tc.Tipo).IsUnique();

            builder.HasMany(tc => tc.FormacoesAcademicas).WithOne(tc => tc.TipoCurso).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("TipoCurso");
        }
    }
}
