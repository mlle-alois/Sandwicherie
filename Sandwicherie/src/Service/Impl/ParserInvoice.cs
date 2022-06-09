using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Sandwicherie.Model;
using Sandwicherie.Repository;

namespace Sandwicherie.Service.Impl;

public class ParserInvoice : Parser
{
    public Dictionary<Sandwich, int> Parse(string input)
    {
        var sandwichesMap = new Dictionary<Sandwich, int>
        {
            { SandwichDatastore.Sandwiches[0], 0 },
            { SandwichDatastore.Sandwiches[1], 0 },
            { SandwichDatastore.Sandwiches[2], 0 }
        };

        var stringSandwiches = input.Split(',').ToList().ConvertAll(sandwich => sandwich.Trim());
        foreach (var stringSandwich in stringSandwiches)
        {
            var regex = new Regex(@"[0-9]* [A-Za-zé]*");
            if (!regex.IsMatch(stringSandwich))
            {
                Console.WriteLine("Invalid sandwich (" + stringSandwich + ")");
                continue;
            }

            var splitedSandwich = stringSandwich.Split(new[] { ' ' }, 2).ToList();

            var foundSandwich = SandwichDatastore.Sandwiches.Find(sandwich => sandwich.Name.Equals(splitedSandwich[1]));
            if (foundSandwich == null)
            {
                Console.WriteLine("Unknown sandwich (" + splitedSandwich[1] + ")");
                continue;
            }
            var numberOfSandwiches = int.Parse(splitedSandwich[0]);
            sandwichesMap[foundSandwich] = numberOfSandwiches + sandwichesMap[foundSandwich];
        }

        return sandwichesMap;
    }
}