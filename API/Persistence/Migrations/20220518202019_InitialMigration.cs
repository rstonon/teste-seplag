using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Pessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf_Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Razao_Social = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome_Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo_empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_Constituicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Porte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caracterizacao_Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantidade_Quota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Valor_Quota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capital_Social = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado_Civil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
