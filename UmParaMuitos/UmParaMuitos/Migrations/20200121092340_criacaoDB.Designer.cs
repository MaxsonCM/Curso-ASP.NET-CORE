﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UmParaMuitos.Models;

namespace UmParaMuitos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200121092340_criacaoDB")]
    partial class criacaoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UmParaMuitos.Models.Empregado", b =>
                {
                    b.Property<int>("EmpregadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<int>("TrabalhoId");

                    b.HasKey("EmpregadoId");

                    b.HasIndex("TrabalhoId");

                    b.ToTable("Empregados");
                });

            modelBuilder.Entity("UmParaMuitos.Models.Trabalho", b =>
                {
                    b.Property<int>("TrabalhoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("TrabalhoId");

                    b.ToTable("Trabalhos");
                });

            modelBuilder.Entity("UmParaMuitos.Models.Empregado", b =>
                {
                    b.HasOne("UmParaMuitos.Models.Trabalho", "Trabalho")
                        .WithMany("Empregados")
                        .HasForeignKey("TrabalhoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
