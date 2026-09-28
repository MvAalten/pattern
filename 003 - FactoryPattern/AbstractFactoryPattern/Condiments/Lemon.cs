using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class Lemon : CondimentDecorator
    {
        public Lemon(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Lemon";
        protected override double TallPrice => 0.20;
        protected override double GrandePrice => 0.25;
        protected override double VendiPrice => 0.30;
    }
}
