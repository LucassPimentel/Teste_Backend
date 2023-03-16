using Frutas.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Frutas.Core.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> opts) : base(opts)
        {
        }

        public DbSet<FruitModel> Frutas { get; set; }
    }
}
