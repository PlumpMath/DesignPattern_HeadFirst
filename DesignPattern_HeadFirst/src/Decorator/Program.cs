using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DeepRoast("RoastCoffee");
            beverage = new Whip(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Console.WriteLine("{0}, cost {1}", beverage.GetDescription(), beverage.Cost());
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
