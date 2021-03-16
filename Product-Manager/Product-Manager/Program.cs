using System;

namespace Product_Manager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager!");

            Console.Write("Enter product code: ");
            String code = Console.ReadLine();

            Console.Write("Enter product description: ");
            String description = Console.ReadLine();

            Console.Write("Enter product price: ");
            String priceStr = Console.ReadLine();
            double price = Convert.ToDouble(priceStr);
            Product p1 = new Product(code, description, price);
            p1.Code = code;
            p1.Description = description;
            p1.Price = price;


            // Console.WriteLine("Product entered: " + code + "," + description + "," + price);

            // string interpolation
            //Console.WriteLine($"Product entered: {code}, {description}, {price}");
            Console.WriteLine(p1);


            Book b1 = new Book("mysql", "Murach's MySQL", 49.50, "Joel Murach");
            Console.WriteLine(b1);
            Software s1 = new Software("vs", "Visual Studio", 0.0, "16.9.1");
            Console.WriteLine(s1);

            Console.WriteLine("Bye!");
        }
    }
}
