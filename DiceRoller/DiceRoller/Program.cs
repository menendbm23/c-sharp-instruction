using System;

namespace DiceRoller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dice Roller\n");

            String choice = "y";
            Random r = new Random();
            while (choice.Equals("y")) {
                int die1 = r.Next(1, 7);
                int die2 = r.Next(1, 7);
                int total = die1 + die2;

            Console.Write("Roll the dice? (y/n): ");
                choice = Console.ReadLine();

                Console.WriteLine("Die 1: " + die1);
                Console.WriteLine("Die 2: " + die2);
                Console.WriteLine("Total: " + total + "\n");

                if (total == 2) {
                    Console.WriteLine("Snake Eyes");


                } else if (total == 12) {
                    Console.WriteLine("Boxcars!");
                }


            }
           
            
            Console.WriteLine("Bye");
        }
    }
}
