using System;

namespace Sandwicherie.src.service.impl
{
public class InputReaderCLI : InputReader
{
    
    public string read()
    {
        Console.Write("What is your order ?\n");
        return Console.ReadLine();
    }

    public bool stopInput()
    {
        while (true)
        {
            Console.Write("Do you want to order again ? (y/n)\n");
            var answer = Console.ReadLine();
            if (answer != null)
                switch (answer.ToLower())
                {
                    case "y":
                        return false;
                    case "n":
                        return true;
                    default:
                        Console.Write("Invalid answer!\n");
                        continue;
                }
        }
    }
}
}