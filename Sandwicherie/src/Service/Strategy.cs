using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service;

public interface Strategy
{
    public void execute(Invoice invoice);
}