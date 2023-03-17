using Frutas.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Frutas.Core.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> opts) : base(opts)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var fruits = new List<FruitModel>() {
                new FruitModel() { Id = 1, Descricao = "Banana", Valor_A = 10, Valor_B = 20 },
                new FruitModel() { Id = 2, Descricao = "Maça", Valor_A = 30, Valor_B = 10 },
                new FruitModel() { Id = 3, Descricao = "Melancia", Valor_A = 20, Valor_B = 5 },
                new FruitModel() { Id = 4, Descricao = "Mamão", Valor_A = 11, Valor_B = 7 }
            };

            modelBuilder.Entity<FruitModel>().HasData(fruits);

        }

        public DbSet<FruitModel> Frutas { get; set; }
    }
}
