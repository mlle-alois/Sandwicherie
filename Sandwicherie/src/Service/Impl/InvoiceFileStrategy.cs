using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl;

public class InvoiceFileStrategy: Strategy
{
    private readonly string PATH = "C:\\Users\\haithem.limam\\Downloads\\Haithem LIMAM\\Invoice.txt";
    public void execute(Invoice invoice)
    {
       var invoiceValue = "";
               var totalAmount = 0.0;
               foreach (var keyValuePair in invoice.sandwichs)
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
       
               if (!(totalAmount > 0)) return;
               invoiceValue += "Total price : " + totalAmount + "€" + "\n";
               using FileStream fs = File.Create(PATH);
               byte[] data = Encoding.UTF8.GetBytes(invoiceValue);
               fs.Write(data, 0, data.Length);

               Console.WriteLine("Invoice file generated");
    }
    
}