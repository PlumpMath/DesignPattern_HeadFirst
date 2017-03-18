using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class DeepRoast : Beverage
    {
        public DeepRoast(string description)
            : base(description)
        { }

        public override double Cost()
        {
            return 1.0;
        }

        public override string GetDescription()
        {
            return this.description;
        }
    }
}
