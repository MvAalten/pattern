using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private static ChocolateBoiler uniqueInstance;
        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public void fill()
        {
            if(empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("De boiler zit vol");
            }
        }

        public void drain()
        {
            if(!empty && boiled)
            {
                empty = true;
                Console.WriteLine("De boiler is leeg");
            }
        }

        public void boil()
        {
            if(!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("De boiler boiled");
            }
        }
    }
}
