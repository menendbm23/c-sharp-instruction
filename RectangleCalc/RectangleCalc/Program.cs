using System;

namespace RectangleCalc {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = width * length;
            Console.WriteLine(area);

            double perimeter = 2 * width + 2 * length;
            Console.WriteLine(perimeter);

           

        }
    }
}
