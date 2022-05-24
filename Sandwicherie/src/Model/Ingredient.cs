using System;

namespace Sandwicherie.Model
{
    public class Ingredient
    {
        private IngredientElement Element { get; }
        private Double Quantity { get; }
        private Unit Unit { get; }

        public Ingredient(IngredientElement element, double quantity, Unit unit)
        {
            Quantity = quantity;
            Element = element;
            Unit = unit;
        }
    }
}