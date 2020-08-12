using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Santi.Repository.Migrations
{
    public partial class inicial_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estrategia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estrategia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filiacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    PartidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidato_Partido_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartidoFiliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    PartidoId = table.Column<int>(nullable: true),
                    FiliacaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartidoFiliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartidoFiliacao_Filiacao_FiliacaoId",
                        column: x => x.FiliacaoId,
                        principalTable: "Filiacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartidoFiliacao_Partido_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colinha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    CandidatoId = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colinha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colinha_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Santinho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracao = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    CandidatoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Santinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Santinho_Candidato_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "Id", "DataAlteracao", "Foto", "Login", "Nome", "Senha", "Sigla", "UsuarioAlteracao" },
                values: new object[] { 1, new DateTime(2020, 8, 11, 23, 2, 10, 45, DateTimeKind.Local).AddTicks(5919), null, "pt", "Partido dos Trabalhadores", "pt123", "PT", 0 });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "Id", "DataAlteracao", "Foto", "Login", "Nome", "Senha", "Sigla", "UsuarioAlteracao" },
                values: new object[] { 2, new DateTime(2020, 8, 11, 23, 2, 10, 46, DateTimeKind.Local).AddTicks(3376), null, "mdb", "Movimento Democrático Brasileiro", "mdb123", "MDB", 0 });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "Id", "DataAlteracao", "Foto", "Login", "Nome", "Senha", "Sigla", "UsuarioAlteracao" },
                values: new object[] { 3, new DateTime(2020, 8, 11, 23, 2, 10, 46, DateTimeKind.Local).AddTicks(3447), null, "psdb", "Partido da Social Democracia Brasileira", "psdb123", "PSDB", 0 });

            migrationBuilder.InsertData(
                table: "Candidato",
                columns: new[] { "Id", "DataAlteracao", "Foto", "Login", "Nome", "NomeFantasia", "Numero", "PartidoId", "Senha", "UsuarioAlteracao" },
                values: new object[] { 1, new DateTime(2020, 8, 11, 23, 2, 10, 48, DateTimeKind.Local).AddTicks(3373), null, "zeca13", "José Miranda dos Santos", "Zeca do PT", 1313, 1, "zeca13", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_PartidoId",
                table: "Candidato",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colinha_CandidatoId",
                table: "Colinha",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidoFiliacao_FiliacaoId",
                table: "PartidoFiliacao",
                column: "FiliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidoFiliacao_PartidoId",
                table: "PartidoFiliacao",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Santinho_CandidatoId",
                table: "Santinho",
                column: "CandidatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colinha");

            migrationBuilder.DropTable(
                name: "Estrategia");

            migrationBuilder.DropTable(
                name: "PartidoFiliacao");

            migrationBuilder.DropTable(
                name: "Santinho");

            migrationBuilder.DropTable(
                name: "Filiacao");

            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "Partido");
        }
    }
}
