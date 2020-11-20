using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of miles driven: ");
            string milesInput = Console.ReadLine();
            float miles = float.Parse(milesInput);

            Console.WriteLine("Amount of gas consumed (gallons): ");
            string gasInput = Console.ReadLine();
            float gallons = float.Parse(gasInput);

            Console.WriteLine("Your car's gas mileage is " + miles / gallons + "mpg.");
        }
    }
}
