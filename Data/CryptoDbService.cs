// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using crypto_sentiment.Models;

// namespace crypto_sentiment.Data {
//   public class CryptoDbService {
//       CryptoDbContext _context;
//       public CryptoDbService(CryptoDbContext context) {
//         _context = context;
//       }

//       public async Task<List<CryptoData>> GetCryptosAsync() {
//         return await _context.Currencies.ToListAsync();
//       }

//       public async Task<CryptoData> GetCryptoDataByIdAsync(string id) {
//         return await _context.Currencies.FindAsync(id);
//       }

//       public async Task<List<CryptoData>> GetCryptoDataBySymbolAsync(string cryptoSymbol) {
//         return await _context.Currencies.Where(x => x.symbol == cryptoSymbol).OrderByDescending(s => s.date).ToListAsync();

//       }

//       public async Task<CryptoData> InsertCryptoDataAsync(CryptoData data) {
//         _context.Currencies.Add(data);
//         await _context.SaveChangesAsync();

//         return data;
//       }

//       public async Task<CryptoData> UpdateCryptoDataAsync(string id, CryptoData s) {
//         var data = await _context.Currencies.FindAsync(id);
        
//         if (data == null)
//           return null;

//         data.currPrice = s.currPrice;
//         data.marketCap = s.marketCap;

//         _context.Currencies.Update(data);
//         await _context.SaveChangesAsync();

//         return data;
//       }

//       public async Task<CryptoData> DeleteCryptoDataAsync(string id)
//       {
//         var data = await _context.Currencies.FindAsync(id);
        
//         if (data == null)
//           return null;

//         _context.Currencies.Remove(data);
//         await _context.SaveChangesAsync();

//         return data;
//       }

//       private bool CryptoDataExists(string id) {
//         return _context.Currencies.Any(e => e.cryptoID == id);
//       }
//   }
// }