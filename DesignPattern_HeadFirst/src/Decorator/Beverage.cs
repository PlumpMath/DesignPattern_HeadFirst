using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class Beverage
    {
        private string description;

        public Beverage()
        { }

        public Beverage(string descrption)
        {
            this.description = descrption;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public abstract double Cost();
    }
}
