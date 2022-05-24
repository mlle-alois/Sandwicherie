using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service
{
    public interface InvoiceOutput
    {
        void Apply(Dictionary<Sandwich, int> sandwichesMap);
    }
}