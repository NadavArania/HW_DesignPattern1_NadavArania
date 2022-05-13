using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    //Singleton
    internal class Clock
    {
        private static Clock instance;
        private static readonly object key = new object();

        private Clock()
        {

        }

        public static Clock InstanceCreate()
        {
            if(instance == null)
            {
                lock (key)
                {
                    if(instance == null)
                    {
                        instance = new Clock();
                    }
                }
            }
            return instance;
        }

        public void GetTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
