using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What area do you live in?");
        string area = Console.ReadLine();
        Console.WriteLine("What city do you live in?");
        string city = Console.ReadLine();
        Console.WriteLine("What street do you live in?");
        string street = Console.ReadLine();
        Console.WriteLine("What country do you live in?");
        string country = Console.ReadLine();
        Address address1 = new Address(street, city, area, country);
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>();

        int quit = 0;
        while (quit != 1)
        {
            Console.WriteLine("What Products would you like? ");
            Console.WriteLine("1. Comfy Chair");
            Console.WriteLine("2. Fabulous Lamp");
            Console.WriteLine("3. Exquisite Dumpling");
            Console.WriteLine("4. Holy Water");
            Console.WriteLine("5. Roundtop Pizza");
            Console.WriteLine("6. Done");
            int youroption = Convert.ToInt32(Console.ReadLine());

            if (youroption == 1)
                products1.Add(new Product("Comfy Chair", 1, 10.0m, 1));
            else if (youroption == 2)
                products1.Add(new Product("Fabulous Lamp", 2, 5.0m, 1));
            else if (youroption == 3)
                products1.Add(new Product("Exquisite Dumpling", 3, 8.0m, 1));
            else if (youroption == 4)
                products1.Add(new Product("Holy Water", 4, 15.0m, 1));
            else if (youroption == 5)
                products1.Add(new Product("Roundtop Pizza", 5, 20.0m, 1));
            else if (youroption == 6)
                quit = 1;
        }

        Order order1 = new Order(customer1, products1);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.ReadLine();
    }
}
