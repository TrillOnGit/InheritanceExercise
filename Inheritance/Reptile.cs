using System;

namespace Inheritance;

public class Reptile : Animal
{
    public bool RegrowingTeeth { get; set; }

    public bool HasTeeth { get; set; }

    public string Diet { get; set; }
    
    public string SkinSituation { get; set; }

    public override void AnimalTraits()
    {
        Console.WriteLine($"The {Name} has the following traits: ");

        Console.WriteLine(HasTeeth
            ? (RegrowingTeeth ? $"Its teeth {RegrowingTeeth}ly regrow!" : "Its teeth don't regrow...")
            : $"Does it have teeth? {HasTeeth} it doesn't!");

        Console.WriteLine($"It maintains itself with a {Diet} lifestyle.");

        Console.WriteLine($"The {Name} has {SkinSituation} to protect itself.");
        
        base.AnimalTraits();
    }
}