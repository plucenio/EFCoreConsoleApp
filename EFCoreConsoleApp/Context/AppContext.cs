using EFCoreConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConsoleApp.Context
{
    public class AppContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CidadeNatalDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 1, Nome = "Torres" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 2, Nome = "Porto Alegre" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 3, Nome = "Canoas" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 4, Nome = "Viamão" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 5, Nome = "Pelotas" });
        }
    }
}
