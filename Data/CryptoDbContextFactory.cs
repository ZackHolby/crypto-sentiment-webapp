using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using crypto_sentiment.Models;

namespace crypto_sentiment.Data {
  public class CryptoDbContextFactory : IDesignTimeDbContextFactory<CryptoDbContext> {
    public CryptoDbContext CreateDbContext(string[] args) {
      var optionsBuilder = new DbContextOptionsBuilder<CryptoDbContext>();
      var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:DefaultConnection");
      optionsBuilder.UseSqlServer(connStr);
      return new CryptoDbContext(optionsBuilder.Options);
    }
  }
}