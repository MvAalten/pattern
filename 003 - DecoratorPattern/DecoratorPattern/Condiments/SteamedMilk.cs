using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Steamed Milk";
        protected override double TallPrice => 0.40;
        protected override double GrandePrice => 0.50;
        protected override double VendiPrice => 0.60;
    }
}
