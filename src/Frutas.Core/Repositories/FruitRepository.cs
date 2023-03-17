using Frutas.Core.Data;
using Frutas.Core.Models;
using Frutas.Core.Repositories.Interfaces;

namespace Frutas.Core.Repositories
{
    public class FruitRepository : IFruitRepository
    {
        private readonly DataBaseContext _dbContext;

        public FruitRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public FruitModel GetFruitById(int id)
        {
            return _dbContext.Frutas.Find(id);
        }

        public List<FruitModel> GetFruits()
        {
            return _dbContext.Frutas.ToList();
        }
    }
}
