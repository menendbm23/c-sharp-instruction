using System;

namespace TravelTimeCalc {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Travel Time Calculator");

            Console.WriteLine("Enter miles:          ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter miles per hour: ");
            double mph = double.Parse(Console.ReadLine());
            Console.WriteLine("Estimated travel time");
            Console.WriteLine("---------------------");
            double hours = miles / mph;
            
            Console.WriteLine("Hours: " + Math.Round(hours, 0));


            double minutes = hours * 60;
            minutes = minutes % 60;

            Console.WriteLine("Minutes: " + Math.Round(minutes, 0));


            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Continue (y/n)? ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");

        }
    }
}
