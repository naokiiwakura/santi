﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Santi.Repository;

namespace Santi.Repository.Migrations
{
    [DbContext(typeof(SantiContext))]
    [Migration("20200805021214_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Santi.Domain.Model.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PartidoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.ToTable("Candidato");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAlteracao = new DateTime(2020, 8, 4, 22, 12, 13, 815, DateTimeKind.Local).AddTicks(8180),
                            Foto = "",
                            Login = "zeca13",
                            Nome = "José Miranda dos Santos",
                            NomeFantasia = "Zeca do PT",
                            Numero = 1313,
                            PartidoId = 1,
                            Senha = "zeca13",
                            UsuarioAlteracao = 0
                        });
                });

            modelBuilder.Entity("Santi.Domain.Model.Colinha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CandidatoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Colinha");
                });

            modelBuilder.Entity("Santi.Domain.Model.Estrategia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Estrategia");
                });

            modelBuilder.Entity("Santi.Domain.Model.Filiacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Filiacao");
                });

            modelBuilder.Entity("Santi.Domain.Model.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sigla")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Partido");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAlteracao = new DateTime(2020, 8, 4, 22, 12, 13, 812, DateTimeKind.Local).AddTicks(4687),
                            Login = "pt",
                            Logo = "",
                            Nome = "Partido dos Trabalhadores",
                            Senha = "pt123",
                            Sigla = "PT",
                            UsuarioAlteracao = 0
                        },
                        new
                        {
                            Id = 2,
                            DataAlteracao = new DateTime(2020, 8, 4, 22, 12, 13, 813, DateTimeKind.Local).AddTicks(5384),
                            Login = "mdb",
                            Logo = "",
                            Nome = "Movimento Democrático Brasileiro",
                            Senha = "mdb123",
                            Sigla = "MDB",
                            UsuarioAlteracao = 0
                        },
                        new
                        {
                            Id = 3,
                            DataAlteracao = new DateTime(2020, 8, 4, 22, 12, 13, 813, DateTimeKind.Local).AddTicks(5454),
                            Login = "psdb",
                            Logo = "",
                            Nome = "Partido da Social Democracia Brasileira",
                            Senha = "psdb123",
                            Sigla = "PSDB",
                            UsuarioAlteracao = 0
                        });
                });

            modelBuilder.Entity("Santi.Domain.Model.PartidoFiliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FiliacaoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FiliacaoId");

                    b.HasIndex("PartidoId");

                    b.ToTable("PartidoFiliacao");
                });

            modelBuilder.Entity("Santi.Domain.Model.Santinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CandidatoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioAlteracao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Santinho");
                });

            modelBuilder.Entity("Santi.Domain.Model.Candidato", b =>
                {
                    b.HasOne("Santi.Domain.Model.Partido", "Partido")
                        .WithMany("Candidatos")
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Santi.Domain.Model.Colinha", b =>
                {
                    b.HasOne("Santi.Domain.Model.Candidato", "Candidato")
                        .WithMany("Colinhas")
                        .HasForeignKey("CandidatoId");
                });

            modelBuilder.Entity("Santi.Domain.Model.PartidoFiliacao", b =>
                {
                    b.HasOne("Santi.Domain.Model.Filiacao", "Filiacao")
                        .WithMany("Partidos")
                        .HasForeignKey("FiliacaoId");

                    b.HasOne("Santi.Domain.Model.Partido", "Partido")
                        .WithMany("Filiacoes")
                        .HasForeignKey("PartidoId");
                });

            modelBuilder.Entity("Santi.Domain.Model.Santinho", b =>
                {
                    b.HasOne("Santi.Domain.Model.Candidato", "Candidato")
                        .WithMany("Santinhos")
                        .HasForeignKey("CandidatoId");
                });
#pragma warning restore 612, 618
        }
    }
}
