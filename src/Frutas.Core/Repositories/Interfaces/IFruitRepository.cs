using Frutas.Core.Models;

namespace Frutas.Core.Repositories.Interfaces
{
    public interface IFruitRepository
    {
        FruitModel GetFruitById(int id);
        List<FruitModel> GetFruits();
    }
}