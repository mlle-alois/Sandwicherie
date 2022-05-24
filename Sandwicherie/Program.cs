using System;
using System.Collections.Generic;
using Sandwicherie.Service;
using Sandwicherie.Service.Impl;

namespace Sandwicherie
{
    internal class Program
    {
        // TODO 1 Jambon beurre, 2 Poulet crudités, 3 Jambon beurre, 3 Dieppois
        public static void Main(string[] args)
        {
            InputReader inputReader = new InputReaderCLI();
            Parser parser = new ParserInvoice();
            InvoiceOutput invoiceOutput = new InvoiceOutputLogger();
            do
            {
                var order = inputReader.Read();

                var sandwiches = parser.Parse(order);

                invoiceOutput.Apply(sandwiches);
            } while (!inputReader.StopInput());
        }
    }
}