using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal interface QuackBehavior
    {
        void RegularQuack()
        {
            Console.WriteLine("Quack");
        }
        void MuteQuack()
        {
            Console.WriteLine("<<silence>>");
        }
        void Squeak()
        {
            Console.WriteLine("Squeek");
        }
    }
} //first ??
