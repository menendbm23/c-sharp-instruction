using System;

namespace MathApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Math app");
            Console.WriteLine("Random number dice roll....");
            String choice = "y";
            Random r = new Random();
            while (choice == "y") {
                int die = r.Next(1, 7);
                Console.WriteLine(die);
                Console.WriteLine("Again?");
                choice = Console.ReadLine();
            }

            //random number between 20 and 50 
            int rand1 = r.Next(20, 51);

            Console.WriteLine("round some numbers: ");
            double d1 = 57.123456789;
            Console.WriteLine(d1);
            // format to two decimal places
            Console.WriteLine(Math.Round(d1, 2));

            Console.WriteLine(Math.Round(d1, 5));

            Console.WriteLine(Math.Round(d1, 6));

            Console.WriteLine("format a currency: ");
            double price = 59.78;
            Console.WriteLine(price.ToString("c"));
            Console.WriteLine("format a percentage: ");
            double percent = 3.789;
            Console.WriteLine(percent.ToString("f"));





            Console.WriteLine("Bye!");
        }
    }
}
