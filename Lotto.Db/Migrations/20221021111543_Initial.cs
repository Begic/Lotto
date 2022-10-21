using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lotto.Db.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lottos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FirstWinNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    SecondWinNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    ThirdWinNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FourthWinNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FifthWinNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    SixthWinNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    HasWon = table.Column<bool>(type: "INTEGER", nullable: true),
                    DateOfWinning = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaidSum = table.Column<decimal>(type: "TEXT", nullable: true),
                    WonSum = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lottos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LottoNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LottoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TippNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FirstNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    SecondNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    ThirdNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FourthNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FifthNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    SixthNumber = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LottoNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LottoNumbers_Lottos_LottoId",
                        column: x => x.LottoId,
                        principalTable: "Lottos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LottoJokerNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LottoNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Draw = table.Column<int>(type: "INTEGER", nullable: true),
                    JokerNumber = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LottoJokerNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LottoJokerNumbers_LottoNumbers_LottoNumberId",
                        column: x => x.LottoNumberId,
                        principalTable: "LottoNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LottoPlusNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LottoNumberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Draw = table.Column<int>(type: "INTEGER", nullable: true),
                    PlusNumberFirst = table.Column<int>(type: "INTEGER", nullable: true),
                    PlusNumberSecond = table.Column<int>(type: "INTEGER", nullable: true),
                    PlusNumberThird = table.Column<int>(type: "INTEGER", nullable: true),
                    PlusNumberFourth = table.Column<int>(type: "INTEGER", nullable: true),
                    PlusNumberFifth = table.Column<int>(type: "INTEGER", nullable: true),
                    PlusNumberSixth = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LottoPlusNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LottoPlusNumbers_LottoNumbers_LottoNumberId",
                        column: x => x.LottoNumberId,
                        principalTable: "LottoNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LottoJokerNumbers_LottoNumberId",
                table: "LottoJokerNumbers",
                column: "LottoNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_LottoNumbers_LottoId",
                table: "LottoNumbers",
                column: "LottoId");

            migrationBuilder.CreateIndex(
                name: "IX_LottoPlusNumbers_LottoNumberId",
                table: "LottoPlusNumbers",
                column: "LottoNumberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LottoJokerNumbers");

            migrationBuilder.DropTable(
                name: "LottoPlusNumbers");

            migrationBuilder.DropTable(
                name: "LottoNumbers");

            migrationBuilder.DropTable(
                name: "Lottos");
        }
    }
}
