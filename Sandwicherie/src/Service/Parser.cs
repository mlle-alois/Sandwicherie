using System.Collections.Generic;

namespace Sandwicherie.src.service
{
    public interface Parser
    {
        List<Sandwich> parse(string input);
    }
}