using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4._1
{
    public static class CoffeeInfo
    {
        private static List<Coffee> ?Coffees; // Static list to hold coffee data

        public static void CreateData() // Method to initialize the coffee data
        {
            Coffees = new List<Coffee>
            {
                new Coffee {BeverageID = 1, BeverageName = "Espresso", BeverageContainer = BeverageContainer.Mug.ToString(), BeverageSize = 1.5,
                CoffeeStrength = "Strong", HasMilk = true, BeverageFlavor = "Rich", BeverageTemperature = 90.0, IsDecaf = false, CoffeeRoast = "Dark",
                TypeOfCoffee = TypeOfCoffee.Espresso.ToString(), BeverageExDate = "2024-12-31"
                },
                new Coffee {BeverageID = 2, BeverageName = "Americano", BeverageContainer = BeverageContainer.Glass.ToString(), BeverageSize = 2.0,
                CoffeeStrength = "Medium", HasMilk = false, BeverageFlavor = "Smooth", BeverageTemperature = 85.0, IsDecaf = false, CoffeeRoast = "Medium",
                TypeOfCoffee = TypeOfCoffee.Americano.ToString(), BeverageExDate = "2024-12-31"
                },
                new Coffee {BeverageID = 3, BeverageName = "Latte", BeverageContainer = BeverageContainer.Tumbler.ToString(), BeverageSize = 3.0,
                CoffeeStrength = "Mild", HasMilk = true, BeverageFlavor = "Creamy", BeverageTemperature = 75.0, IsDecaf = true, CoffeeRoast = "Light",
                TypeOfCoffee = TypeOfCoffee.Latte.ToString(), BeverageExDate = "2024-12-31"
                },
                new Coffee {BeverageID = 4, BeverageName = "Cappuccino", BeverageContainer = BeverageContainer.Mug.ToString(), BeverageSize = 2.5,
                CoffeeStrength = "Strong", HasMilk = true, BeverageFlavor = "Frothy", BeverageTemperature = 80.0, IsDecaf = false, CoffeeRoast = "Dark",
                TypeOfCoffee = TypeOfCoffee.Cappuccino.ToString(), BeverageExDate = "2024-12-31"
                },
                new Coffee {BeverageID = 5, BeverageName = "Mocha", BeverageContainer = BeverageContainer.PlasticCup.ToString(), BeverageSize = 3.5,
                CoffeeStrength = "Medium", HasMilk = false, BeverageFlavor = "Chocolatey", BeverageTemperature = 70.0, IsDecaf = true, CoffeeRoast = "Medium",
                TypeOfCoffee = TypeOfCoffee.Mocha.ToString(), BeverageExDate = "2024-12-31"
                },

            };
        }
        public static List<Coffee> GetCoffees() // Method to retrieve the list of coffees
        {
            return Coffees;
        }
    }
}
