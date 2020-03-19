using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CarStorage;

namespace CarStorage
{
    public class Car
    {
        private int _price = 0;

        public string Color { get; set; }

        public int Price
        {
            get => _price;
            set
            {
                if (_price > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine($"Hey, this price is invalid {value} !!11");
                }
            }
        }

        public string Name { get; set; }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);
            return Price - (saleSum / 100.0 * Price);
        }

        
    }

    
}
