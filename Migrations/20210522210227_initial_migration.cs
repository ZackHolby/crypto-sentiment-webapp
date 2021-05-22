using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crypto_sentiment.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    cryptoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    currencyID = table.Column<int>(type: "int", nullable: false),
                    currPrice = table.Column<int>(type: "int", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    market_cap = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.cryptoID);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "cryptoID", "currPrice", "currencyID", "date", "market_cap", "slug", "symbol" },
                values: new object[,]
                {
                    { "6a834a16-ff87-41ac-80a1-45dd01c14cd1", 1000, 1, new DateTime(2021, 5, 22, 17, 2, 27, 523, DateTimeKind.Local).AddTicks(6957), 10L, "Bitcoin", "BTC" },
                    { "79715810-eb30-4326-ad4f-edb3a83a0b84", 2000, 2, new DateTime(2021, 5, 22, 17, 2, 27, 527, DateTimeKind.Local).AddTicks(3236), 20L, "Ethereum", "ETH" },
                    { "ce57ec07-b889-417e-a525-91c5a92142ca", 3000, 3, new DateTime(2021, 5, 22, 17, 2, 27, 527, DateTimeKind.Local).AddTicks(3291), 30L, "Cardano", "ADA" },
                    { "62f3656b-4ae3-4d1b-aab9-075cb47d13b8", 4000, 4, new DateTime(2021, 5, 22, 17, 2, 27, 527, DateTimeKind.Local).AddTicks(3298), 40L, "Chainlink", "LINK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
