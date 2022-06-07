namespace Sandwicherie.Model
{
    public class Ingredient
    {
        public IngredientElement Element { get; set; }
        public Double Quantity { get; set; }
        public Unit Unit { get; set; }

        
         public Ingredient(IngredientElement element, double quantity, Unit unit)
          {
              Quantity = quantity;
              Element = element;
              Unit = unit;
          }

    }
}