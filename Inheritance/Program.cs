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
            
            Bird osprey = new Bird
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

            Reptile monitorLizard = new Reptile
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

            Animal.DisplayValues(monitorLizard, osprey);
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
