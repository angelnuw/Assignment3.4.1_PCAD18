using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._4._1
{
    public abstract class Beverage
    {
       
        public int BeverageID { get; set; }
        public string ?BeverageName { get; set; }
        public string ?BeverageExDate { get; set; }
        public string ?BeverageContainer { get; set; }
        public double BeverageSize { get; set; }
        public string ?BeverageFlavor { get; set; }
        public double BeverageTemperature { get; set; }

    }
}
