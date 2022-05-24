using System;
using System.Collections.Generic;

namespace Sandwicherie.Model
{
    public class Sandwich
    {
        private String Name { get; }
        private List<Ingredient> Ingredients { get; }
        private Double Price { get; }

        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            this.Ingredients = ingredients;
            this.Name = name;
            this.Price = price;
        }
    }
}