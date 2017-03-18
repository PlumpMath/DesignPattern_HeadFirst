using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class Beverage
    {
        protected string description;

        public Beverage()
        { }

        public Beverage(string descrption)
        {
            this.description = descrption;
        }

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
