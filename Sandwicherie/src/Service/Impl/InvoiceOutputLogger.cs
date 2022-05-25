using System;
using System.Collections.Generic;
using System.Text;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl
{
    public class InvoiceOutputLogger : InvoiceOutput
    {
        public void Apply(Dictionary<Sandwich, int> sandwichesMap)
        {
            var totalAmount = 0.0;
            foreach (var keyValuePair in sandwichesMap)
            {
                var numberOfSandwiches = keyValuePair.Value;
                totalAmount += numberOfSandwiches * keyValuePair.Key.Price;
                if (numberOfSandwiches <= 0) continue;
                Console.WriteLine(numberOfSandwiches + " " + keyValuePair.Key.Name);
                foreach (var ingredient in keyValuePair.Key.Ingredients)
                {
                    Console.WriteLine("\t" + ingredient.Quantity +
                                      ingredient.Unit.ToDescriptionString() + " " +
                                      ingredient.Element.ToDescriptionString());
                }
            }

            if (!(totalAmount > 0)) return;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Total price : " + totalAmount + "€");
        }
    }
}