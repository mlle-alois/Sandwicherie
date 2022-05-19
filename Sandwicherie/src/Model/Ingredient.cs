namespace Sandwicherie;

public class Ingredient
{
    private IngredientElement element { get; }
    private Double quantity{ get; }
    private Unit unit { get; }

    public Ingredient(IngredientElement element, double quantity,Unit unit)
    {
        this.quantity = quantity;
        this.element = element;
        this.unit = unit;
    }
}