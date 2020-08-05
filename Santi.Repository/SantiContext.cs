using Microsoft.EntityFrameworkCore;
using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santi.Repository
{
    public class SantiContext : DbContext
    {
        public SantiContext(DbContextOptions<SantiContext> options) : base(options)
        {

        }

        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Colinha> Colinha { get; set; }
        public DbSet<Estrategia> Estrategia { get; set; }
        public DbSet<Filiacao> Filiacao { get; set; }
        public DbSet<Partido> Partido { get; set; }
        public DbSet<PartidoFiliacao> PartidoFiliacao { get; set; }
        public DbSet<Santinho> Santinho { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partido>().HasData(
                new Partido
                {
                    Id = 1,
                    DataAlteracao = DateTime.Now,
                    Nome = "Partido dos Trabalhadores",
                    Sigla = "PT",
                    Login = "pt",
                    Senha = "pt123",
                    Logo = ""
                },
                new Partido
                {
                    Id = 2,
                    DataAlteracao = DateTime.Now,
                    Nome = "Movimento Democrático Brasileiro",
                    Sigla = "MDB",
                    Login = "mdb",
                    Senha = "mdb123",
                    Logo = ""
                },
                new Partido
                {
                    Id = 3,
                    DataAlteracao = DateTime.Now,
                    Nome = "Partido da Social Democracia Brasileira",
                    Sigla = "PSDB",
                    Login = "psdb",
                    Senha = "psdb123",
                    Logo = ""
                });


            modelBuilder.Entity<Candidato>().HasData(
                new Candidato
                {
                    Id = 1,
                    DataAlteracao = DateTime.Now,
                    Nome = "José Miranda dos Santos",
                    NomeFantasia = "Zeca do PT",
                    Numero = 1313,
                    Login = "zeca13",
                    Senha = "zeca13",
                    Foto = "",
                    PartidoId = 1
                });

        }
    }
}
