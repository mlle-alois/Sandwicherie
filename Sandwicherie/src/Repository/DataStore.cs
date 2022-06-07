using System.Collections.Generic;
using Sandwicherie.Model;
using Sandwicherie.src.Model;

namespace Sandwicherie.Repository
{
    public static class SandwichDatastore
    {
        public static readonly List<Sandwich> Sandwiches = new List<Sandwich>()
        {
               new Sandwich("Ham butter", new List<Ingredient>()
            {
                { new IngredientBuilder().
                       WithElement(IngredientElement.BREAD)
                       .WithQuantity(1)
                       .build() },
                 { new IngredientBuilder().
                       WithElement(IngredientElement.HAM)
                       .WithQuantity(1)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.BUTTER)
                       .WithQuantity(10)
                       .WithUnit(Unit.GRAM)
                       .build() },
            }, 3.5),

              new Sandwich("Chicken and raw vegetables", new List<Ingredient>()
            {
                { new IngredientBuilder().
                       WithElement(IngredientElement.BREAD)
                       .WithQuantity(1)
                       .build() },
                 { new IngredientBuilder().
                       WithElement(IngredientElement.EGG)
                       .WithQuantity(1)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.TOMATO)
                       .WithQuantity(0.5)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.CHICKEN_SLICE)
                       .WithQuantity(1)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.MAYONNAISE)
                       .WithQuantity(10)
                       .WithUnit(Unit.GRAM)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.SALAD)
                       .WithQuantity(10)
                       .WithUnit(Unit.GRAM)
                       .build() },
            }, 5),
              new Sandwich("Dieppois", new List<Ingredient>()
            {
                { new IngredientBuilder().
                       WithElement(IngredientElement.BREAD)
                       .WithQuantity(1)
                       .build() },
                 { new IngredientBuilder().
                       WithElement(IngredientElement.TUNA)
                       .WithQuantity(50)
                       .WithUnit(Unit.GRAM)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.TOMATO)
                       .WithQuantity(0.5)
                       .build() },
             
                  { new IngredientBuilder().
                       WithElement(IngredientElement.MAYONNAISE)
                       .WithQuantity(10)
                       .WithUnit(Unit.GRAM)
                       .build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.SALAD)
                       .WithQuantity(10)
                       .WithUnit(Unit.GRAM)
                       .build() },

            }, 4.5),
        };
    }
}