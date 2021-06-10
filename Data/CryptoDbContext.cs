using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using crypto_sentiment.Models;
using System.Linq;


public class CryptoDbContext : DbContext
{

    public DbSet<CryptoData> Currencies {get;set;}
    public CryptoDbContext(DbContextOptions<CryptoDbContext> options)
        : base(options)
    {
    }

    
}