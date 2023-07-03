using System;

namespace Inheritance;

public class Bird : Animal
{
    public int NumberOfWings { get; set; }

    public bool FliesSolo { get; set; } 
    
    public bool HasFeathers { get; set; }
    
    public string NestLocation { get; set; }

    public override void AnimalTraits()
    {
        Console.WriteLine($"The {Name} has the following traits: ");

        Console.WriteLine(FliesSolo
            ? $"It flies alone, flapping its {NumberOfWings} wings."
            : $"It uses its {NumberOfWings} wings to fly in a group!");

        Console.WriteLine(HasFeathers
            ? $"The {Name}'s wings are feathered."
            : "Its wings are featherless.");

        Console.WriteLine($"and it builds its nest in {NestLocation}.");

        base.AnimalTraits();
    }
}