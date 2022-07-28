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
                       WithElement(IngredientElement.Bread)
                       .WithQuantity(1)
                       .Build() },
                 { new IngredientBuilder().
                       WithElement(IngredientElement.Ham)
                       .WithQuantity(1)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Butter)
                       .WithQuantity(10)
                       .WithUnit(Unit.Gram)
                       .Build() },
            }, 3.5),

              new Sandwich("Chicken and raw vegetables", new List<Ingredient>()
            {
                { new IngredientBuilder().
                       WithElement(IngredientElement.Bread)
                       .WithQuantity(1)
                       .Build() },
                 { new IngredientBuilder().
                       WithElement(IngredientElement.Egg)
                       .WithQuantity(1)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Tomato)
                       .WithQuantity(0.5)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.ChickenSlice)
                       .WithQuantity(1)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Mayonnaise)
                       .WithQuantity(10)
                       .WithUnit(Unit.Gram)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Salad)
                       .WithQuantity(10)
                       .WithUnit(Unit.Gram)
                       .Build() },
            }, 5),
              new Sandwich("Dieppois", new List<Ingredient>()
            {
                { new IngredientBuilder().
                       WithElement(IngredientElement.Bread)
                       .WithQuantity(1)
                       .Build() },
                 { new IngredientBuilder().
                       WithElement(IngredientElement.Tuna)
                       .WithQuantity(50)
                       .WithUnit(Unit.Gram)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Tomato)
                       .WithQuantity(0.5)
                       .Build() },
             
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Mayonnaise)
                       .WithQuantity(10)
                       .WithUnit(Unit.Gram)
                       .Build() },
                  { new IngredientBuilder().
                       WithElement(IngredientElement.Salad)
                       .WithQuantity(10)
                       .WithUnit(Unit.Gram)
                       .Build() },

            }, 4.5),
        };
    }
}