using Sandwicherie.Service;
using Sandwicherie.Service.Impl;

namespace Sandwicherie
{
    internal static class Program
    {
        // TODO 1 Ham butter, 2 Chicken and raw vegetables, 3 Ham butter, 3 Dieppois
        public static void Main(string[] args)
        {
            InputReader inputReader = new InputReaderCLI();
            Parser parser = new ParserInvoice();
            InvoiceFactory invoiceFactory = new InvoiceStringFactory();
            var invoiceOutput = new InvoiceOutput(invoiceFactory);
            do
            {
                var order = inputReader.Read();

                var sandwiches = parser.Parse(order);

                invoiceOutput.Apply(sandwiches);
            } while (!inputReader.StopInput());
        }
    }
}