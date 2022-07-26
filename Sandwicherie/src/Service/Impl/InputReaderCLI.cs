using System;

namespace Sandwicherie.Service.Impl
{
public class InputReaderCLI : InputReader
{
    
    public string Read()
    {
        Console.WriteLine("What is your order ?");
        return Console.ReadLine();
    }

    public bool StopInput()
    {
        while (true)
        {
            Console.WriteLine("Do you want to order again ? (y/n)");
            var answer = Console.ReadLine();
            if (answer != null)
                switch (answer.ToLower())
                {
                    case "y":
                        return false;
                    case "n":
                        return true;
                    default:
                        Console.WriteLine("Invalid answer!");
                        continue;
                }
        }
    }

    public bool ChooseOutput()
    {
        while (true)
        {
            Console.WriteLine("Do you want a file order ? (y/n)");
            var answer = Console.ReadLine();
            if (answer != null)
                switch (answer.ToLower())
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Invalid answer!");
                        continue;
                }
        }
    }
}
}