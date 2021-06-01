using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crypto_sentiment.Migrations
{
    public partial class new_pc_initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "beda3f8a-8a23-40f0-b8d9-4e616a90fad4", 1000.0, 1, new DateTime(2021, 6, 1, 15, 51, 40, 949, DateTimeKind.Local).AddTicks(4255), 10L, "Bitcoin", "BTC" },
                    { "a86ca76c-b2c0-4c8f-805c-411248879f4b", 2000.0, 2, new DateTime(2021, 6, 1, 15, 51, 40, 950, DateTimeKind.Local).AddTicks(7290), 20L, "Ethereum", "ETH" },
                    { "a857740d-c25b-4a92-8ab2-bc310213e3bf", 3000.0, 3, new DateTime(2021, 6, 1, 15, 51, 40, 950, DateTimeKind.Local).AddTicks(7317), 30L, "Cardano", "ADA" },
                    { "d5340578-6369-4e42-8eb0-6f4505d93622", 4000.0, 4, new DateTime(2021, 6, 1, 15, 51, 40, 950, DateTimeKind.Local).AddTicks(7322), 40L, "Chainlink", "LINK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "a857740d-c25b-4a92-8ab2-bc310213e3bf");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "a86ca76c-b2c0-4c8f-805c-411248879f4b");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "beda3f8a-8a23-40f0-b8d9-4e616a90fad4");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "d5340578-6369-4e42-8eb0-6f4505d93622");

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
    }
}
