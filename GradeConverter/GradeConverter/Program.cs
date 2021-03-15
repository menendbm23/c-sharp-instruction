using System;

namespace GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter");



            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter a numerical grade: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 88) {
                    Console.WriteLine("Letter grade: A");

                } else if (grade >= 80) {
                    Console.WriteLine("Letter grade: B");
                } else if (grade >= 67) {
                    Console.WriteLine("Letter grade: C");
                } else if (grade >= 60) {
                    Console.WriteLine("Letter grade: D");

                } else if (grade >= 0) {
                    Console.WriteLine("Letter grade: F");
                }
                Console.WriteLine("Continue (y/n)? ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");
        }
    }
}
