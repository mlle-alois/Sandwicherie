using System.Collections.Generic;

namespace Sandwicherie.src.service
{
    public interface InvoiceOutput
    {
        void apply(List<Sandwich> sandwiches);
    }
}