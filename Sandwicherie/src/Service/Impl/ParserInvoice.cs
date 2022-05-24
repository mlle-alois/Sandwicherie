using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl;

public class ParserInvoice : Parser
{
    public List<Sandwich> Parse(string input)
    {
        var sandwiches = new List<Sandwich>();
        
        var stringSandwiches = input.Split(',').ToList().ConvertAll(sandwich => sandwich.Trim());
        foreach (var stringSandwich in stringSandwiches)
        {
            Console.WriteLine(stringSandwich);
            
            Regex regex = new Regex(@"[0-9]* [A-Za-zé]*");
            if (!regex.IsMatch(stringSandwich))
            {
                Console.WriteLine("Invalid order");
                return sandwiches;
            }
        }
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