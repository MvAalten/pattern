using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class Liqour : CondimentDecorator
    {
        public Liqour(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Liqour";
        protected override double TallPrice => 0.80;
        protected override double GrandePrice => 0.90;
        protected override double VendiPrice => 1.00;
    }
}
