using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class Condiment : Beverage
    {
        public abstract string GetDescription();
    }
}
