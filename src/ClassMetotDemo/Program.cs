﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // New Customers
            Customer customer1 = new Customer();
            customer1.Id = 348265;
            customer1.Name = "Mert";
            customer1.Nickname = "manlyy";

            Customer customer2 = new Customer();
            customer2.Id = 273669;
            customer2.Name = "Samet";
            customer2.Nickname = "solVe";

            Customer customer3 = new Customer();
            customer3.Id = 497615;
            customer3.Name = "Umut";
            customer3.Nickname = "trakS";

            // An Array For Customer's List
            Customer[] customers = new Customer[] 
            {
                customer1, customer2, customer3
            };

            // Bank Name
            Console.WriteLine("xxx Bankasi{0}------------", Environment.NewLine);

            // Add Place
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            // List Place
            customerManager.List();

            // Dell Place
            customerManager.Dell(customer2);
            Console.ReadKey();
        }
    }
}
