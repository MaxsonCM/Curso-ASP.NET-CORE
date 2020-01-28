﻿using GerenciadorDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Mapeamento
{
    public class TipoDespesasMap : IEntityTypeConfiguration<TipoDespesa>
    {
        public void Configure(EntityTypeBuilder<TipoDespesa> builder)
        {
            builder.HasKey(td => td.TipoDespesaId);
            builder.Property(td => td.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(td => td.Despesas).WithOne(td => td.TipoDespesas).HasForeignKey(td => td.TipoDespesaId);
            builder.ToTable("TipoDespesas");
        }
    }
}
