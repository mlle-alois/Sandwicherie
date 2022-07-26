using System.Collections.Generic;
using Sandwicherie.Model;

namespace Sandwicherie.Service
{
    public interface Parser
    {
        Invoice Parse(string input);
    }
}