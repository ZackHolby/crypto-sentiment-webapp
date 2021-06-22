using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crypto_sentiment.Models;

namespace crypto_sentiment.Data {
  public class CryptoDbService {
      private readonly IDbContextFactory<CryptoDbContext> _context;
      public CryptoDbService(IDbContextFactory<CryptoDbContext> context) {
        _context = context;
      }

      public async Task<List<CryptoData>> GetCryptosAsync() {
        using (var context = _context.CreateDbContext())
        {
            return await context.Currencies.ToListAsync();
        }
        
      }

      public async Task<CryptoData> GetCryptoDataByIdAsync(string id) {
        using (var context = _context.CreateDbContext())
        {
            return await context.Currencies.FindAsync(id);
        }
      }

      public async Task<List<CryptoData>> GetCryptoDataBySymbolAsync(string cryptoSymbolOrSlug) {
        using (var context = _context.CreateDbContext())
        {
            return await context.Currencies.Where(x => x.symbol == cryptoSymbolOrSlug || x.slug == cryptoSymbolOrSlug).OrderByDescending(s => s.date).ToListAsync();
        }
        

      }

      public async Task<CryptoData> InsertCryptoDataAsync(CryptoData data) {
        using (var context = _context.CreateDbContext())
        {
            context.Currencies.Add(data);
            await context.SaveChangesAsync();

            return data;        
        }
        
      }

      public async Task<CryptoData> UpdateCryptoDataAsync(string id, CryptoData cd) {
        using (var context = _context.CreateDbContext())
        {
            var data = await context.Currencies.FindAsync(id);
        
            if (data == null)
              return null;

            data.currPrice = cd.currPrice;
            data.marketCap = cd.marketCap;

            context.Currencies.Update(data);
            await context.SaveChangesAsync();

            return data;        
        }
        
        
      }

      public async Task<CryptoData> DeleteCryptoDataAsync(string id)
      {
        using (var context = _context.CreateDbContext())
        {
            var data = await context.Currencies.FindAsync(id);
        
            if (data == null)
              return null;

            context.Currencies.Remove(data);
            await context.SaveChangesAsync();

            return data;
        }
        
      }

      private bool CryptoDataExists(string id) {
        using (var context = _context.CreateDbContext())
        {
            return context.Currencies.Any(e => e.cryptoID == id);
        }
        
      }
  }
}