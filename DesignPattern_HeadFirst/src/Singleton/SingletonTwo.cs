using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    sealed public class SingletonTwo
    {
        private static volatile SingletonTwo instance;
        private static Object sysRoot = new Object();

        private SingletonTwo() { }

        public static SingletonTwo Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sysRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonTwo();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
