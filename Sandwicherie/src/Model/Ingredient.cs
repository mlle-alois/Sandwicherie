namespace Sandwicherie.Model
{
    public class Ingredient
    {
        public IngredientElement Element { get; }
        public double Quantity { get; }
        public Unit Unit { get; }

        public Ingredient(IngredientElement element, double quantity, Unit unit)
        {
            Quantity = quantity;
            Element = element;
            Unit = unit;
        }
    }
}