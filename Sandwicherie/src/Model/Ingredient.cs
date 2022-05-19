namespace Sandwicherie;

public class Ingredient
{
    private IngredientElement element;
    private Double quantity;
    private Unit unit;

    public Ingredient(IngredientElement element, double quantity,Unit unit)
    {
        this.quantity = quantity;
        this.element = element;
        this.unit = unit;
    }
}