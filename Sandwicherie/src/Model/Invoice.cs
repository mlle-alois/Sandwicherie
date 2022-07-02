using System.Collections.Generic;

namespace Sandwicherie.Model;

public class Invoice
{
    public Dictionary<Sandwich, int> sandwichs { get; }
    public Invoice(Dictionary<Sandwich, int> sandwichs)
    {
        this.sandwichs = sandwichs;
    }
}