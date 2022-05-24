using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service
{
    public interface Parser
    {
        List<Sandwich> Parse(string input);
    }
}