namespace Sandwicherie;

public class Sandwich
{
    private String name;
    private List<Ingredient> ingredients;
    private Double price;

    public Sandwich(string name, List<Ingredient> ingredients, double price)
    {
        this.ingredients = ingredients;
        this.name = name;
        this.price = price;
    }
}