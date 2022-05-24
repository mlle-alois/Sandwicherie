using Sandwicherie.src.service;
using Sandwicherie.src.service.impl;
using System;

namespace Sandwicherie;

public class Program
{
    static void Main(string[] args)
    {
        InputReader inputReader = new InputReaderCLI();
        inputReader.read();
    }
}