using System;

namespace Student_Registration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name: ");
            String lName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            String year = Console.ReadLine();

            Console.Write("Welcome" + fName + "" + lName + "!");
            Console.Write("Your registration is complete.");
            Console.Write("Your temporary password is: " + fName + "*" + year);

        }
    }
}
