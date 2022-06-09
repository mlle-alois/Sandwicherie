using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl;

public class InvoiceFileFactory: InvoiceFactory
{
    public override Invoice GenerateInvoice(Dictionary<Sandwich, int> sandwichesMap)
    {
        throw new System.NotImplementedException();
    }
}