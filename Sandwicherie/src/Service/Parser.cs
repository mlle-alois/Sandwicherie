using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service
{
    public interface Parser
    {
        Dictionary<Sandwich, int> Parse(string input);
    }
}