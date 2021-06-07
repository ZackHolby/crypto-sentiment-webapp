﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crypto_sentiment.Models;

namespace crypto_sentiment.Migrations
{
    [DbContext(typeof(CryptoDbContext))]
    [Migration("20210607161756_init_migration")]
    partial class init_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("crypto_sentiment.Models.CryptoData", b =>
                {
                    b.Property<string>("cryptoID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("currPrice")
                        .HasColumnType("float");

                    b.Property<int>("currencyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<long>("marketCap")
                        .HasColumnType("bigint");

                    b.Property<string>("slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cryptoID");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            cryptoID = "0762a8b5-e72f-40e3-82f6-1ee3b2a6297f",
                            currPrice = 1000.0,
                            currencyID = 1,
                            date = new DateTime(2021, 6, 7, 12, 17, 56, 153, DateTimeKind.Local).AddTicks(5316),
                            marketCap = 10L,
                            slug = "Bitcoin",
                            symbol = "BTC"
                        },
                        new
                        {
                            cryptoID = "2fcaede9-4c7c-4d6c-af5a-4ec9751561f1",
                            currPrice = 2000.0,
                            currencyID = 2,
                            date = new DateTime(2021, 6, 7, 12, 17, 56, 154, DateTimeKind.Local).AddTicks(8671),
                            marketCap = 20L,
                            slug = "Ethereum",
                            symbol = "ETH"
                        },
                        new
                        {
                            cryptoID = "95350dc6-9124-4a6b-968d-ee0ad16bbbd4",
                            currPrice = 3000.0,
                            currencyID = 3,
                            date = new DateTime(2021, 6, 7, 12, 17, 56, 154, DateTimeKind.Local).AddTicks(8697),
                            marketCap = 30L,
                            slug = "Cardano",
                            symbol = "ADA"
                        },
                        new
                        {
                            cryptoID = "6711f549-bedb-4c0a-bdc7-212549bc336c",
                            currPrice = 4000.0,
                            currencyID = 4,
                            date = new DateTime(2021, 6, 7, 12, 17, 56, 154, DateTimeKind.Local).AddTicks(8703),
                            marketCap = 40L,
                            slug = "Chainlink",
                            symbol = "LINK"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
