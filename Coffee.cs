using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4._1
{
    public class Coffee : Beverage
    {
        public static class CoffeeInfo 
        {
            private static List<Coffee> Coffees;

            public static void CreateData()
            {
                Coffees = new List<Coffee>
                {
                         new Coffee { coffeeName = "Espresso", coffeeType = "Hot Beverage", coffeeSize = "Small", coffeeStrength = "Strong", coffeeFlavor = "None", coffeeTemperature = "Hot" },
                         new Coffee { coffeeName = "Americano", coffeeType = "Hot Beverage", coffeeSize = "Medium", coffeeStrength = "Medium", coffeeFlavor = "None", coffeeTemperature = "Hot"},
                         new Coffee { coffeeName = "Latte", coffeeType = "Hot Beverage", coffeeSize = "Large", coffeeStrength = "Medium", coffeeFlavor = "Vanilla", coffeeTemperature = "Hot"},
                         new Coffee { coffeeName = "Cappuccino", coffeeType = "Hot Beverage", coffeeSize = "Medium", coffeeStrength = "Strong", coffeeFlavor = "Chocolate", coffeeTemperature = "Hot"},
                         new Coffee { coffeeName = "Mocha", coffeeType = "Hot Beverage", coffeeSize = "Large", coffeeStrength = "Medium", coffeeFlavor = "Chocolate", coffeeTemperature = "Hot"}

                };
            }
            public static List<Coffee> GetCoffees()
            {
                return Coffees;
            }   
        }
    }
}
