using System;

namespace CarStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[1];

            for (var i=0; i < cars.Length; i++)
            {
                cars[i] = new Car();
                Console.WriteLine("Please input car's name:");
                cars[i].Name = Console.ReadLine();

                Console.WriteLine("Please input car's price:");
                cars[i].Price = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please input car's color:");
                cars[i].Color = Console.ReadLine();
            }

            Console.WriteLine($"Source price: {cars[0].Price}; Price after sale: {cars[0].GetSale()}");
        }
    }
}
