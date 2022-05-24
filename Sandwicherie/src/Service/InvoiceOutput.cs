using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service
{
    public interface InvoiceOutput
    {
        void Apply(List<Sandwich> sandwiches);
    }
}