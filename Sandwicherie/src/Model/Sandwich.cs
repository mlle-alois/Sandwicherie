using System;
using System.Collections.Generic;

namespace Sandwicherie.Model
{
    public class Sandwich
    {
        public string Name { get; }
        public List<Ingredient> Ingredients { get; }
        public double Price { get; }

        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            this.Ingredients = ingredients;
            this.Name = name;
            this.Price = price;
        }
    }
}