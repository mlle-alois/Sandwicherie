using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service.Impl
{
    public class InvoiceOutput
    {
        private readonly InvoiceFactory _invoiceFactory;

        public InvoiceOutput(InvoiceFactory invoiceFactory)
        {
            this._invoiceFactory = invoiceFactory;
        }

        public void Apply(Dictionary<Sandwich, int> sandwichesMap)
        {
            var invoice = this._invoiceFactory.GenerateInvoice(sandwichesMap);
            invoice.PrintInvoice();
        }
    }
}