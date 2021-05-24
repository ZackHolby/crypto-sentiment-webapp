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
          cryptoID = Guid.NewGuid().ToString(),
          currencyID = 1,
          currPrice = 1000.0,
          symbol = "BTC",
          slug = "Bitcoin",
          market_cap = (long)10
        }, new {
          date =  DateTime.Now,
          cryptoID = Guid.NewGuid().ToString(),
          currencyID = 2,
          currPrice = 2000.0,
          symbol = "ETH",
          slug = "Ethereum",
          market_cap = (long)20
        }, new {
          date = DateTime.Now,
          cryptoID = Guid.NewGuid().ToString(),
          currencyID = 3,
          currPrice = 3000.0,
          symbol = "ADA",
          slug = "Cardano",
          market_cap = (long)30
        }, new {
          date = DateTime.Now,
          cryptoID = Guid.NewGuid().ToString(),
          currencyID = 4,
          currPrice = 4000.0,
          symbol = "LINK",
          slug = "Chainlink",
          market_cap = (long)40
        }
      );
    }
  }
}