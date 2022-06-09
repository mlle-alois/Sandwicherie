using System;
using System.Text;

namespace Sandwicherie.Model;

public class InvoiceString: Invoice
{
    private readonly string _invoiceValue;

    public InvoiceString(string invoiceValue)
    {
        this._invoiceValue = invoiceValue;
    }

    public void PrintInvoice()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(this._invoiceValue);
    }
}