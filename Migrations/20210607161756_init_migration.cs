using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace crypto_sentiment.Migrations
{
    public partial class init_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "market_cap",
                table: "Currencies",
                newName: "marketCap");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "cryptoID", "currPrice", "currencyID", "date", "marketCap", "slug", "symbol" },
                values: new object[,]
                {
                    { "0762a8b5-e72f-40e3-82f6-1ee3b2a6297f", 1000.0, 1, new DateTime(2021, 6, 7, 12, 17, 56, 153, DateTimeKind.Local).AddTicks(5316), 10L, "Bitcoin", "BTC" },
                    { "2fcaede9-4c7c-4d6c-af5a-4ec9751561f1", 2000.0, 2, new DateTime(2021, 6, 7, 12, 17, 56, 154, DateTimeKind.Local).AddTicks(8671), 20L, "Ethereum", "ETH" },
                    { "95350dc6-9124-4a6b-968d-ee0ad16bbbd4", 3000.0, 3, new DateTime(2021, 6, 7, 12, 17, 56, 154, DateTimeKind.Local).AddTicks(8697), 30L, "Cardano", "ADA" },
                    { "6711f549-bedb-4c0a-bdc7-212549bc336c", 4000.0, 4, new DateTime(2021, 6, 7, 12, 17, 56, 154, DateTimeKind.Local).AddTicks(8703), 40L, "Chainlink", "LINK" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "0762a8b5-e72f-40e3-82f6-1ee3b2a6297f");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "2fcaede9-4c7c-4d6c-af5a-4ec9751561f1");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "6711f549-bedb-4c0a-bdc7-212549bc336c");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "cryptoID",
                keyValue: "95350dc6-9124-4a6b-968d-ee0ad16bbbd4");

            migrationBuilder.RenameColumn(
                name: "marketCap",
                table: "Currencies",
                newName: "market_cap");

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
    }
}
