using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    sealed public class SingletonOne
    {
        private static readonly SingletonOne instance = new SingletonOne();

        private SingletonOne() { }

        public static SingletonOne Instance
        { 
            get
            {
                return instance;
            }
        }
    }
}
