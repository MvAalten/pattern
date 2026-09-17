using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class BlackChocolate : CondimentDecorator
    {
        public BlackChocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Black Chocolate";
        protected override double TallPrice => 0.30;
        protected override double GrandePrice => 0.35;
        protected override double VendiPrice => 0.40;
    }
}
