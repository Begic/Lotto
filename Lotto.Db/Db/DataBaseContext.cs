using Microsoft.EntityFrameworkCore;
using Lotto.Db.Entities;
using Microsoft.Data.Sqlite;

namespace Lotto.Db.Db;

public class DataBaseContext : DbContext
{ 
    public DbSet<Entities.Lotto> Lottos { get; set; }
    public DbSet<LottoJokerNumber> LottoJokerNumbers { get; set; }
    public DbSet<LottoNumber> LottoNumbers { get; set; }
    public DbSet<LottoPlusNumber> LottoPlusNumbers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        SqliteConnectionStringBuilder connectionStringBuilder = new();
        connectionStringBuilder.DataSource = "ProdDB.db";
        optionsBuilder.UseSqlite(connectionStringBuilder.ToString());
    }
}