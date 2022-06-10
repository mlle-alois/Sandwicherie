using Sandwicherie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandwicherie.src.Model
{
    public class IngredientBuilder
    {
        private IngredientElement Element { get; set; }
        private double Quantity { get; set; }
        private Unit Unit { get; set; }

        public IngredientBuilder WithElement(IngredientElement ingredientElement)
        {
            Element = ingredientElement;
            return this;
        }

        public IngredientBuilder WithQuantity(double quantity)
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
            Unit = Unit.Empty;
            return this;
        }

        public Ingredient Build()
        {
            return new Ingredient(Element, Quantity, Unit);
        }
    }
}