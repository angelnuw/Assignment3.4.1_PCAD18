using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4._1
{
    public class Coffee : Beverage //Inherits from Beverage class
    {
        public bool IsDecaf { get; set; } 
        public string ?CoffeeRoast { get; set; } 
        public string ?TypeOfCoffee { get; set; }
        public string ?CoffeeStrength { get; set; } // Strength of the coffee
        public bool HasMilk { get; set; } // Indicates if the coffee has milk

    }
}
