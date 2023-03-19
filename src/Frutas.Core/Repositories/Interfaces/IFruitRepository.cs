using Frutas.Core.Models;

namespace Frutas.Core.Repositories.Interfaces
{
    public interface IFruitRepository
    {
        List<FruitModel> GetFruits();
    }
}