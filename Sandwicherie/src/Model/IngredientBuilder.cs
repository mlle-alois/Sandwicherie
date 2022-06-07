using Sandwicherie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandwicherie.src.Model
{
    public class IngredientBuilder
    {
        public IngredientElement Element { get; set; }
        public Double Quantity { get; set; }
        public Unit Unit { get; set; }
        public IngredientBuilder()
        {

        }

        public IngredientBuilder WithElement(IngredientElement ingredientElement)
        {
            Element = ingredientElement;
            return this;
        }

        public IngredientBuilder WithQuantity(Double quantity)
        {
            Quantity = quantity;
            return this;
        }


        public IngredientBuilder WithUnit(Unit unit)
        {
            Unit = unit;
            return this;
        }

        public IngredientBuilder WithoutUnit()
        {
            Unit = Unit.EMPTY;
            return this;
        }

        public Ingredient build()
        {
   
            return new Ingredient(Element, Quantity, Unit);
        }
    }
}
