namespace Sandwicherie;

public class Sandwich
{
    private String name { get; }
    private List<Ingredient> ingredients { get; }
    private Double price { get; }

    public Sandwich(string name, List<Ingredient> ingredients, double price)
    {
        this.ingredients = ingredients;
        this.name = name;
        this.price = price;
    }
}