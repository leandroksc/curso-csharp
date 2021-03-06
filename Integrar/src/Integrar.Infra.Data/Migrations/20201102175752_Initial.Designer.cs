﻿// <auto-generated />
using System;
using Integrar.Infra.Data.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Integrar.Infra.Data.Migrations
{
    [DbContext(typeof(IntegrarDBContext))]
    [Migration("20201102175752_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
