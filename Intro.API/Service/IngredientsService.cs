using Intro.API.Database;
using Intro.API.Model;

namespace Intro.API.Service
{
    public class IngredientsService : IIngredientsService
    {
        private readonly IDatabaseManager _databaseService;
        public IngredientsService(IDatabaseManager databaseService)
        {
            _databaseService = databaseService;
        }
        public bool AddIngredient(Ingredient ing)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _databaseService.GetAllIngredients();
        }
    }
}
