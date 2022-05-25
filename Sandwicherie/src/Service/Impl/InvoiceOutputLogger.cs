using System;
using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl
{
    public class InvoiceOutputLogger:InvoiceOutput
    {
        public void Apply(Dictionary<Sandwich, int> sandwichesMap)
        {
            foreach (var keyValuePair in sandwichesMap)
            {
                var numberOfSandwiches = keyValuePair.Value;
                if (numberOfSandwiches > 0)
                {
                    Console.WriteLine(numberOfSandwiches + " " + keyValuePair.Key.Name);
                }
            }
        }
    }
}