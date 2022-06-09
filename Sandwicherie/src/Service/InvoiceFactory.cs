using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service;

public abstract class InvoiceFactory
{
    public abstract Invoice GenerateInvoice(Dictionary<Sandwich, int> sandwichesMap);
}