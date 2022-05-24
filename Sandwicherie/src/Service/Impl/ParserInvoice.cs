using System.Collections.Generic;
using Sandwicherie.src.service;

namespace Sandwicherie.Service.Impl;

public class ParserInvoice : Parser
{
    public List<Sandwich> parse(string input)
    {
        return new List<Sandwich>()
        {
            new Sandwich("Jambon beurre", new List<Ingredient>()
            {
                { new(IngredientElement.BREAD, 1, Unit.EMPTY) },
                { new(IngredientElement.HAM, 1, Unit.EMPTY) },
                { new(IngredientElement.BUTTER, 10, Unit.GRAM) }
            }, 3.5)
        };
    }
}