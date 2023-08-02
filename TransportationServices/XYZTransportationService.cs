﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationServices
{
    
    internal class XYZTransportationService : ITransportationService<Vehicle, Product>// 50 pr 500 km
    {
        public double MaxWeight = 7.5;
       

        public void Transport(Vehicle[] vehicle, Product[] products, int distance)
        {
            double weight = 0;
            for (int i = 0; i < products.Length; i++)
            {
                weight += products[i].Weight;
            }
            Console.WriteLine("Do you want info about trucks?(yes or no ) ");
            if (Console.ReadLine() == "yes")
            {
                foreach (var item in vehicle)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(item);
                    Console.ResetColor();
                }
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Total amount is:{(decimal)weight * Mercedes.CarryValue}");
            Console.ResetColor();
        }
    }
}
