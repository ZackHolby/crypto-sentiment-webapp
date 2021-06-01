using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crypto_sentiment.Migrations
{
    public partial class new_pc_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "cryptoID", "currPrice", "currencyID", "date", "market_cap", "slug", "symbol" },
                values: new object[,]
                {
                    { "6d28bdcb-87f7-475e-8755-2fe9521f457f", 1000.0, 1, new DateTime(2021, 6, 1, 15, 37, 45, 299, DateTimeKind.Local).AddTicks(1692), 10L, "Bitcoin", "BTC" },
                    { "c80c2e61-fd5d-4d0e-b7e8-21a1188e7d63", 2000.0, 2, new DateTime(2021, 6, 1, 15, 37, 45, 300, DateTimeKind.Local).AddTicks(5095), 20L, "Ethereum", "ETH" },
                    { "617ae0d7-976f-4750-989c-abf7c1c7a99e", 3000.0, 3, new DateTime(2021, 6, 1, 15, 37, 45, 300, DateTimeKind.Local).AddTicks(5122), 30L, "Cardano", "ADA" },
                    { "067572e3-dbfa-44f3-b552-297de9ec127b", 4000.0, 4, new DateTime(2021, 6, 1, 15, 37, 45, 300, DateTimeKind.Local).AddTicks(5127), 40L, "Chainlink", "LINK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "067572e3-dbfa-44f3-b552-297de9ec127b");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "617ae0d7-976f-4750-989c-abf7c1c7a99e");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "6d28bdcb-87f7-475e-8755-2fe9521f457f");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "c80c2e61-fd5d-4d0e-b7e8-21a1188e7d63");

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
    }
}
