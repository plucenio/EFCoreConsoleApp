﻿// <auto-generated />
using EFCoreConsoleApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreConsoleApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20181212193529_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreConsoleApp.Entities.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Torres"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Porto Alegre"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Canoas"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Viamão"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Pelotas"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
