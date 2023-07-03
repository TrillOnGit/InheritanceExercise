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

    private static void AnimalTraits(Animal anim)
    {
        Console.WriteLine($"It uses {anim.SensOrgan} to see.");
        
        Console.WriteLine(anim.IsVertebrate ? "It has a spine!" : "It is an invertebrate.");
        
        Console.Write($"It {anim.Eats}ly eats");
        
        Console.WriteLine($" and has {anim.NumberOfLegs} legs!");
    }
    public static void DisplayValues(Reptile rep, Bird birb)
    {
        var repStart = rep.Name[..1];
        var birdStart = birb.Name[..1];
        Console.WriteLine($"Type {repStart} if you would like reptile information or {birdStart} for bird information.");
        var userWant = Console.ReadLine();

        if (userWant == null) return;
        if (userWant.ToUpper() == repStart)
        {
            Console.WriteLine($"The {rep.Name} has the following traits: ");

            Console.WriteLine(rep.HasTeeth
                ? (rep.RegrowingTeeth ? $"Its teeth {rep.RegrowingTeeth}ly regrow!" : "Its teeth don't regrow...")
                : $"Does it have teeth? {rep.HasTeeth} it doesn't!");

            Console.WriteLine($"It maintains itself with a {rep.Diet} lifestyle.");

            Console.WriteLine($"The {rep.Name} has {rep.SkinSituation} to protect itself.");

            AnimalTraits(rep);
        }
        else if (userWant.ToUpper() == birdStart)
        {
            //Bird
            Console.WriteLine($"The {birb.Name} has the following traits: ");

            Console.WriteLine(birb.FliesSolo
                ? $"It flies alone, flapping its {birb.NumberOfWings} wings."
                : $"It uses its {birb.NumberOfWings} wings to fly in a group!");

            Console.WriteLine(birb.HasFeathers
                ? $"The {birb.Name}'s wings are feathered."
                : "Its wings are featherless.");

            Console.WriteLine($"and it builds its nest in {birb.NestLocation}.");

            AnimalTraits(birb);
        }
        else
        {
            Console.WriteLine("Neither of our birds or reptiles start with that input!");
        }
    }
}