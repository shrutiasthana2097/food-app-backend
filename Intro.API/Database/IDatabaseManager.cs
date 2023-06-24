using Intro.API.Model;

namespace Intro.API.Database
{
    public interface IDatabaseManager
    {
        public List<Ingredient> GetAllIngredients();
        public bool AddIngredient(Ingredient ing);
    }
}
