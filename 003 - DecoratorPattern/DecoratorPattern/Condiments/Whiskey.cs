using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Whiskey : CondimentDecorator
    {
        public Whiskey(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Whiskey";
        protected override double TallPrice => 1.00;
        protected override double GrandePrice => 1.10;
        protected override double VendiPrice => 1.20;
    }
}
