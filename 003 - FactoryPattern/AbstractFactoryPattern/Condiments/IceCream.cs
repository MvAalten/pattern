using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class IceCream : CondimentDecorator
    {
        public IceCream(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Ice cream";
        protected override double TallPrice => 0.60;
        protected override double GrandePrice => 0.70;
        protected override double VendiPrice => 0.80;
    }
}
