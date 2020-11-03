using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrar.Infra.Data.Migrations
{
    public partial class MigPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataInternacao = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Internado = table.Column<bool>(nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Rg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
