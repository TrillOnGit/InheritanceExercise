using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            
            var osprey = new Bird
            {
                Name = "Osprey",
                SensOrgan = "Eyes",
                IsVertebrate = true,
                Eats = true,
                NumberOfLegs = 2,
                HasFeathers = true,
                FliesSolo = true,
                NestLocation = "Treetops",
                NumberOfWings = 2
            };

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var monitorLizard = new Reptile
            {
                Name = "Monitor Lizard",
                SensOrgan = "Eyes",
                IsVertebrate = true,
                Eats = true,
                NumberOfLegs = 4,
                RegrowingTeeth = true,
                HasTeeth = true,
                Diet = "Omnivore",
                SkinSituation = "Smooth Scales"
            };
            
            //This is technically cleaner due to class organization
            
            var repStart = monitorLizard.Name[..1];
            var birdStart = osprey.Name[..1];
        
            Console.WriteLine(
                $"Type {repStart} if you would like reptile information or {birdStart} for bird information.");
            var userWant = Console.ReadLine();

            if (userWant == null) return;
            if (userWant.ToUpper() == repStart)
            {
                monitorLizard.AnimalTraits();
            }
            else if (userWant.ToUpper() == birdStart)
            {
                osprey.AnimalTraits();
            }
            else
            {
                Console.WriteLine("Neither of our birds or reptiles start with that input!");
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
