using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Repository
{
    public static class SandwichDatastore
    {
        public static readonly List<Sandwich> Sandwiches = new List<Sandwich>()
        {
            new Sandwich("Ham butter", new List<Ingredient>()
            {
                { new(IngredientElement.Bread, 1, Unit.Empty) },
                { new(IngredientElement.Ham, 1, Unit.Empty) },
                { new(IngredientElement.Butter, 10, Unit.Gram) }
            }, 3.5),
            new Sandwich("Chicken and raw vegetables", new List<Ingredient>()
            {
                { new(IngredientElement.Bread, 1, Unit.Empty) },
                { new(IngredientElement.Egg, 1, Unit.Empty) },
                { new(IngredientElement.Tomato, 0.5, Unit.Empty) },
                { new(IngredientElement.ChickenSlice, 1, Unit.Empty) },
                { new(IngredientElement.Mayonnaise, 10, Unit.Gram) },
                { new(IngredientElement.Salad, 10, Unit.Gram) }
            }, 5),
            new Sandwich("Dieppois", new List<Ingredient>()
            {
                { new(IngredientElement.Bread, 1, Unit.Empty) },
                { new(IngredientElement.Tuna, 50, Unit.Gram) },
                { new(IngredientElement.Tomato, 0.5, Unit.Empty) },
                { new(IngredientElement.Mayonnaise, 10, Unit.Gram) },
                { new(IngredientElement.Salad, 10, Unit.Gram) }
            }, 4.5)
        };
    }
}