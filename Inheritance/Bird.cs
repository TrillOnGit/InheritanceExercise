namespace Inheritance;

public class Bird : Animal
{
    public int NumberOfWings { get; set; }

    public bool FliesSolo { get; set; } 
    
    public bool HasFeathers { get; set; }
    
    public string NestLocation { get; set; }
}