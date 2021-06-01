using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace crypto_sentiment.Models {
  public class CryptoDbContextFactory : IDesignTimeDbContextFactory<CryptoDbContext> {
    public CryptoDbContext CreateDbContext(string[] args) {
      var optionsBuilder = new DbContextOptionsBuilder<CryptoDbContext>();
      var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:DefaultConnection");
      optionsBuilder.UseSqlServer(connStr);
      return new CryptoDbContext(optionsBuilder.Options);
    }
  }
}