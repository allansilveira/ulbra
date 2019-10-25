using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace contaluz.Migrations
{
    public partial class ADDImovelToManyConta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "houseid",
                table: "Conta",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conta_houseid",
                table: "Conta",
                column: "houseid");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Imovel_houseid",
                table: "Conta",
                column: "houseid",
                principalTable: "Imovel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Imovel_houseid",
                table: "Conta");

            migrationBuilder.DropTable(
                name: "Imovel");

            migrationBuilder.DropIndex(
                name: "IX_Conta_houseid",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "houseid",
                table: "Conta");
        }
    }
}
