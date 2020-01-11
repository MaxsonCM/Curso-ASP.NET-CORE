﻿// <auto-generated />
using System;
using Annotations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Annotations.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Annotations.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnName("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnName("Idade")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnName("CPF")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("ntext");

                    b.HasKey("PersonId");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
