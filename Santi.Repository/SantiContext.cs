using Microsoft.EntityFrameworkCore;
using Santi.Domain.Model;
using Santi.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                    Foto = null
                },
                new Partido
                {
                    Id = 2,
                    DataAlteracao = DateTime.Now,
                    Nome = "Movimento Democrático Brasileiro",
                    Sigla = "MDB",
                    Login = "mdb",
                    Senha = "mdb123",
                    Foto = null
                },
                new Partido
                {
                    Id = 3,
                    DataAlteracao = DateTime.Now,
                    Nome = "Partido da Social Democracia Brasileira",
                    Sigla = "PSDB",
                    Login = "psdb",
                    Senha = "psdb123",
                    Foto = null
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
                    Foto = null,
                    PartidoId = 1
                });





        }


        //Salvamento de data alteracao automatica
        public override int SaveChanges()
        {
            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is EntityBase && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((EntityBase)entityEntry.Entity).DataAlteracao = DateTime.Now;
            }

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is EntityBase && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((EntityBase)entityEntry.Entity).DataAlteracao = DateTime.Now;
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
