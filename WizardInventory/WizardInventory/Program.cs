using System;
using System.Collections.Generic;

namespace WizardInventory {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory game\n");
            displayMenu();

            List<String> inventory = new List<String>();
            inventory.Add("Wooden Staff");
            inventory.Add("Wizard hat");
            inventory.Add("cloth shoes");

            while (true) {
                String command = "";
                if (command == "show") {
                    show(inventory);
                } else if (command == "grab") {
                    grab(inventory);
                } else if (command == "edit") {
                    edit(inventory);
                } else if (command == "drop") {
                    drop(inventory);
                } else if (command == "exit") {
                    break;
                } else {
                    Console.WriteLine("Not a valid command. Please try again. \n");
                }
            }

                Console.WriteLine("Bye!");
            }

        private static void displayMenu() {
                Console.WriteLine("COMMAND MENU");
                Console.WriteLine("show - Show all items");
                Console.WriteLine("grab - Grab an item");
                Console.WriteLine("edit - Edit an item");
                Console.WriteLine("drop - Drop an item");
                Console.WriteLine("exit - Exit program\n");
                Console.ReadLine();
            }



        
        private static void show(List<String> inventory) {
            for (int i = 0; i < inventory.Count; i++) {
                String item = inventory.Add(i);
                int number = i + 1;
                Console.WriteLine(number + "." + item);

            }
    }
        private static void grab(List<String> inventory) {
                if (inventory.Count >= 4) {
                    Console.WriteLine("You can't carry any more items. Drop something first.\n");
                } else {
                    String item = "";
                    inventory.Add(item);
                    Console.WriteLine(item + " was added.\n");
                }
        }
        private static void edit(List<String> inventory) {
            int number = Console.ReadLine("Number: ");
            if (number < 1 || number > inventory.Count) {
                Console.WriteLine("Invalid item number.\n");
            } else {
                String item = Console.ReadLine("Update name: ");
                inventory.Insert(number - 1, item);
                Console.WriteLine("Item number " + number + "was updated.\n");
            }
            }
        private static void drop(List<String> inventory) {
            int number = Console.ReadLine("Number: ");
                if (number < 1 || number > inventory.Count) {
                Console.WriteLine("Invalid item number.\n");
            } else {
                String item = inventory.Remove(number - 1);
                Console.WriteLine(item + " was dropped.\n");
            }
        }
    }

}