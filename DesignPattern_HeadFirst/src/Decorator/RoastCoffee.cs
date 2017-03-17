using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class RoastCoffee : Beverage
    {
        public RoastCoffee(string description)
            : base(description)
        { }

        public override double Cost()
        {
            return 1.0;
        }
    }
}
