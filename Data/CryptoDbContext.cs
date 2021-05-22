using System;
using Microsoft.EntityFrameworkCore;

namespace crypto_sentiment.Models {
  public class CryptoDbContext : DbContext {
    public DbSet<CryptoData> Currencies { get; set; }

    public CryptoDbContext(DbContextOptions<CryptoDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
      base.OnModelCreating(builder);

      builder.Entity<CryptoData>().HasData(
        new {
          date = DateTime.Now,
          CurrencyID = 1,
          currPrice = 1000,
          symbol = "BTC",
          slug = "Bitcoin",
          market_cap = 10
        }, new {
          date =  DateTime.Now,
          CurrencyID = 2,
          currPrice = 2000,
          symbol = "ETH",
          slug = "Ethereum",
          market_cap = 20
        }, new {
          date = DateTime.Now,
          CurrencyID = 3,
          currPrice = 3000,
          symbol = "ADA",
          slug = "Cardano",
          market_cap = 30
        }, new {
          date = DateTime.Now,
          CurrencyID = 4,
          currPrice = 4000,
          symbol = "LINK",
          slug = "Chainlink",
          market_cap = 40
        }
      );
    }
  }
}