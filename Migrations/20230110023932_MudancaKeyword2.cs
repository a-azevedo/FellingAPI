using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FellingAPI.Migrations
{
    /// <inheritdoc />
    public partial class MudancaKeyword2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeywordSentimento");

            migrationBuilder.AddColumn<int>(
                name: "SentimentoId",
                table: "Keywords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_SentimentoId",
                table: "Keywords",
                column: "SentimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_Sentimentos_SentimentoId",
                table: "Keywords",
                column: "SentimentoId",
                principalTable: "Sentimentos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_Sentimentos_SentimentoId",
                table: "Keywords");

            migrationBuilder.DropIndex(
                name: "IX_Keywords_SentimentoId",
                table: "Keywords");

            migrationBuilder.DropColumn(
                name: "SentimentoId",
                table: "Keywords");

            migrationBuilder.CreateTable(
                name: "KeywordSentimento",
                columns: table => new
                {
                    keywordsId = table.Column<int>(type: "int", nullable: false),
                    sentimentosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordSentimento", x => new { x.keywordsId, x.sentimentosId });
                    table.ForeignKey(
                        name: "FK_KeywordSentimento_Keywords_keywordsId",
                        column: x => x.keywordsId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeywordSentimento_Sentimentos_sentimentosId",
                        column: x => x.sentimentosId,
                        principalTable: "Sentimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeywordSentimento_sentimentosId",
                table: "KeywordSentimento",
                column: "sentimentosId");
        }
    }
}
