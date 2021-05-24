using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crypto_sentiment.Migrations
{
    public partial class updated_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "62f3656b-4ae3-4d1b-aab9-075cb47d13b8");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "6a834a16-ff87-41ac-80a1-45dd01c14cd1");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "79715810-eb30-4326-ad4f-edb3a83a0b84");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "ce57ec07-b889-417e-a525-91c5a92142ca");

            migrationBuilder.AlterColumn<double>(
                name: "currPrice",
                table: "Currencies",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "cryptoID", "currPrice", "currencyID", "date", "market_cap", "slug", "symbol" },
                values: new object[,]
                {
                    { "d9ac68ab-7cbf-4ac3-8638-2a1474314a3a", 1000.0, 1, new DateTime(2021, 5, 24, 13, 54, 18, 923, DateTimeKind.Local).AddTicks(4111), 10L, "Bitcoin", "BTC" },
                    { "77e4a50f-f860-4293-93be-22ae6adb5814", 2000.0, 2, new DateTime(2021, 5, 24, 13, 54, 18, 927, DateTimeKind.Local).AddTicks(448), 20L, "Ethereum", "ETH" },
                    { "6267ae51-3776-4078-b322-934edae266e2", 3000.0, 3, new DateTime(2021, 5, 24, 13, 54, 18, 927, DateTimeKind.Local).AddTicks(502), 30L, "Cardano", "ADA" },
                    { "46c02d70-7f5f-48ea-8eb1-aa36f4043ed2", 4000.0, 4, new DateTime(2021, 5, 24, 13, 54, 18, 927, DateTimeKind.Local).AddTicks(510), 40L, "Chainlink", "LINK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "46c02d70-7f5f-48ea-8eb1-aa36f4043ed2");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "6267ae51-3776-4078-b322-934edae266e2");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "77e4a50f-f860-4293-93be-22ae6adb5814");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "d9ac68ab-7cbf-4ac3-8638-2a1474314a3a");

            migrationBuilder.AlterColumn<int>(
                name: "currPrice",
                table: "Currencies",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
    }
}
