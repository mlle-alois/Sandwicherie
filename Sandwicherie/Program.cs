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
            Context context = new Context();
            do
            {
                var order = inputReader.Read();
                var outputType = inputReader.ChooseOutput();
                if (outputType)
                {
                    context.strategy = new InvoiceFileStrategy();
                }
                else
                {
                    context.strategy = new InvoiceConsoleStrategy();
                }
                var invoice = parser.Parse(order);
                context.executeStrategy(invoice);
            } while (!inputReader.StopInput());
        }
    }
}