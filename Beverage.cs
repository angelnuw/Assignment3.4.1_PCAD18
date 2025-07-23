using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4._1
{
    public abstract class Beverage //derived class from Coffee
    {
        //inherit from Coffee class
        public string coffeeName { get; set; }
        public string coffeeType { get; set; }
        public string coffeeSize { get; set; }
        public string coffeeStrength { get; set; }
        public string coffeeFlavor { get; set; }
        public string coffeeTemperature { get; set; }

    }
}
