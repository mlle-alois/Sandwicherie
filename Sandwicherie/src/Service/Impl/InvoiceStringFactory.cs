using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl;

public class InvoiceStringFactory: InvoiceFactory
{
    public override Invoice GenerateInvoice(Dictionary<Sandwich, int> sandwichesMap)
    {
        var invoiceValue = "";
        var totalAmount = 0.0;
        foreach (var keyValuePair in sandwichesMap)
        {
            var numberOfSandwiches = keyValuePair.Value;
            totalAmount += numberOfSandwiches * keyValuePair.Key.Price;
            if (numberOfSandwiches <= 0) continue;
            invoiceValue += numberOfSandwiches + " " + keyValuePair.Key.Name + "\n";
            foreach (var ingredient in keyValuePair.Key.Ingredients)
            {
                invoiceValue += "\t" + ingredient.Quantity +
                                ingredient.Unit.ToDescriptionString() + " " +
                                ingredient.Element.ToDescriptionString() + "\n";
            }
        }

        if (!(totalAmount > 0)) return new InvoiceString("");
        invoiceValue += "Total price : " + totalAmount + "€" + "\n";
        return new InvoiceString(invoiceValue);
    }
}