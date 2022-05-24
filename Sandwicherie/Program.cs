using System;
using System.Collections.Generic;
using Sandwicherie.Service.Impl;
using Sandwicherie.src.service;
using Sandwicherie.src.service.impl;
using Sandwicherie.src.Service.Impl;

namespace Sandwicherie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InputReader inputReader = new InputReaderCLI();
            Parser parser = new ParserInvoice();
            InvoiceOutput invoiceOutput = new InvoiceOutputLogger();
            do
            {
                String order = inputReader.read();

                List<Sandwich> sandwiches = parser.parse(order);

                invoiceOutput.apply(sandwiches);
            } while (!inputReader.stopInput());
        }
    }
}