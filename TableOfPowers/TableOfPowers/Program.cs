using System;

namespace TableOfPowers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Squares and Cubes table");

            String choice = "y";
            while (choice.Equals("y")) {
            Console.Write("Enter an integer: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Number\tSquared\tCubed\n");
            Console.WriteLine("======\t=======\t=====\n");

            for (int i = 1; i <= x; i++) {
            int square = i * i;
            int cube = i * i * i;
            Console.WriteLine(i + "\t" + square + "\t" + cube + "\t");
                

            }
                Console.Write("Continue (y/n): ");
                choice = Console.ReadLine();

            }



            Console.WriteLine("Bye");
        }
    }
}
