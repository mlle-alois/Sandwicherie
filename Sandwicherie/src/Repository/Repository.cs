namespace Sandwicherie.Repository;

public static class SandwichDatastore
{
    public static IDictionary<int, Sandwich> sandwiches = new Dictionary<int, Sandwich>()
    {
        {
            1, new Sandwich("Jambon beurre", new List<Ingredient>()
            {
                { new(IngredientElement.BREAD, 1, Unit.EMPTY) },
                { new(IngredientElement.HAM, 1, Unit.EMPTY) },
                { new(IngredientElement.BUTTER, 10, Unit.GRAM) }
            }, 3.5)
        },
        {
            2, new Sandwich("Poulet crudités", new List<Ingredient>()
            {
                { new(IngredientElement.BREAD, 1, Unit.EMPTY) },
                { new(IngredientElement.EGG, 1, Unit.EMPTY) },
                { new(IngredientElement.TOMATO, 0.5, Unit.EMPTY) },
                { new(IngredientElement.CHICKEN_SLICE, 1, Unit.EMPTY) },
                { new(IngredientElement.MAYONNAISE, 10, Unit.GRAM) },
                { new(IngredientElement.SALAD, 10, Unit.GRAM) }
            }, 5)
        },
        {
            3, new Sandwich("Dieppois", new List<Ingredient>()
            {
                { new(IngredientElement.BREAD, 1, Unit.EMPTY) },
                { new(IngredientElement.TUNA, 50, Unit.GRAM) },
                { new(IngredientElement.TOMATO, 0.5, Unit.EMPTY) },
                { new(IngredientElement.MAYONNAISE, 10, Unit.GRAM) },
                { new(IngredientElement.SALAD, 10, Unit.GRAM) }
            }, 4.5)
        },
    };
}