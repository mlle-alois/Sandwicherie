using System;
using System.IO;
using System.Text;

namespace Sandwicherie.Model;

public class InvoiceFile: Invoice
{
    private readonly string _invoiceValue;
    private readonly string PATH = "Invoice.txt";
    public InvoiceFile(string invoiceValue)
    {
        this._invoiceValue = invoiceValue;
    }

    public void PrintInvoice()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(this._invoiceValue);
        using FileStream fs = File.Create(PATH);
        byte[] data = Encoding.UTF8.GetBytes(this._invoiceValue);
        fs.Write(data, 0, data.Length);

        Console.WriteLine("Invoice file generated");
    }
}