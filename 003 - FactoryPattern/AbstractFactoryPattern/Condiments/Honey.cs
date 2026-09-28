using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class Honey : CondimentDecorator
    {
        public Honey(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Honey";
        protected override double TallPrice => 0.25;
        protected override double GrandePrice => 0.30;
        protected override double VendiPrice => 0.35;
    }
}
