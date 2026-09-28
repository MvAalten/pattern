using AbstractFactoryPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected abstract string Name { get; }
        protected abstract double TallPrice { get; }
        protected abstract double GrandePrice { get; }
        protected abstract double VendiPrice { get; }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", " + Name;
        }

        public override double cost()
        {
            return baseBeverage.cost() + PriceForSize();
        }

        private double PriceForSize()
        {
            switch (Size)
            {
                case Size.TALL:
                    return TallPrice;
                case Size.GRANDE:
                    return GrandePrice;
                case Size.VENDI:
                    return VendiPrice;
                default:
                    return TallPrice;
            }
        }
    }
}
