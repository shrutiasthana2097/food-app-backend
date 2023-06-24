using Intro.API.Model;

namespace Intro.API.Service
{
    public interface IIngredientsService
    {
        public List<Ingredient> GetAllIngredients();
        public bool AddIngredient(Ingredient ing);
    }
}
