using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    sealed public class SingletonThree
    {
        private SingletonThree() { }

        public static SingletonThree Instance
        {
            get
            {
                return InnerClass.Instance;
            }
        }

        private class InnerClass
        {
            static InnerClass() { }

            private static readonly SingletonThree instance = new SingletonThree();

            public static SingletonThree Instance
            {
                get
                {
                    return instance;
                }
            }
        }
    }
}
