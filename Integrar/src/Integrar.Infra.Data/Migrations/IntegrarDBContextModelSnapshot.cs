﻿// <auto-generated />
using System;
using Integrar.Infra.Data.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Integrar.Infra.Data.Migrations
{
    [DbContext(typeof(IntegrarDBContext))]
    partial class IntegrarDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Integrar.Domain.Entities.Mural", b =>
                {
                    b.Property<int>("MuralID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<string>("Aviso");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Email");

                    b.Property<string>("Titulo");

                    b.HasKey("MuralID");

                    b.ToTable("Mural");
                });

            modelBuilder.Entity("Integrar.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataInternacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<bool>("Internado");

                    b.Property<string>("Nome");

                    b.Property<string>("Rg");

                    b.Property<int>("Sexo");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
