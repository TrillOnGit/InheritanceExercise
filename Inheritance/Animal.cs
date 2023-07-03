using System;
using System.Collections;

namespace Inheritance;

public class Animal
{
    public string SensOrgan { get; set; }

    public bool IsVertebrate { get; set; }

    public bool Eats { get; set; }

    public int NumberOfLegs { get; set; }

    public string Name { get; set; }

    public virtual void AnimalTraits()
    {
        Console.WriteLine($"It uses {SensOrgan} to see.");

        Console.WriteLine(IsVertebrate ? "It has a spine!" : "It is an invertebrate.");

        Console.Write($"It {Eats}ly eats");

        Console.WriteLine($" and has {NumberOfLegs} legs!");
    }
}