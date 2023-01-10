using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class MudancaKeyword3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_Sentimentos_SentimentoId",
                table: "Keywords");

            migrationBuilder.RenameColumn(
                name: "grafia",
                table: "Keywords",
                newName: "Grafia");

            migrationBuilder.AlterColumn<int>(
                name: "SentimentoId",
                table: "Keywords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_Sentimentos_SentimentoId",
                table: "Keywords",
                column: "SentimentoId",
                principalTable: "Sentimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_Sentimentos_SentimentoId",
                table: "Keywords");

            migrationBuilder.RenameColumn(
                name: "Grafia",
                table: "Keywords",
                newName: "grafia");

            migrationBuilder.AlterColumn<int>(
                name: "SentimentoId",
                table: "Keywords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_Sentimentos_SentimentoId",
                table: "Keywords",
                column: "SentimentoId",
                principalTable: "Sentimentos",
                principalColumn: "Id");
        }
    }
}
