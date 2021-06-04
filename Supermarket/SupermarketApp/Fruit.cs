﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketApp
{
    public class Fruit : IFruit
    {
        public string Name { get; set; }
        public bool Domestic { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public Fruit(string name, bool domestic, double price, int weight, string description)
        {
            Name = name;
            Domestic = domestic;
            Price = price;
            Weight = weight;
            Description = description;
            if (Description.Length > 30)
            {
                Description = Description.Substring(0, 10);
            }
        }

        public string PrintFruit()
        {
            string weightNull = Weight == 0 ? "N/A" : $"{Weight}";
            return $" . . . {Name}\n       Price: ${Price}\n       {Description}. . .\n       Weight: {weightNull}";
        }

    }
}
