using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        protected override string Name => "Milk Foam";
        protected override double TallPrice => 0.10;
        protected override double GrandePrice => 0.15;
        protected override double VendiPrice => 0.20;
    }
}
