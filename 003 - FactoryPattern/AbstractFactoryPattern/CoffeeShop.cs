using AbstractFactoryPattern.Beverages;

namespace AbstractFactoryPattern
{
    // Creator: orders always go through OrderBeverage, the subclass decides what gets made.
    internal abstract class CoffeeShop
    {
        public Beverage OrderBeverage(CoffeeMix mix)
        {
            Beverage beverage = CreateBeverage(mix);
            // Common handling for every drink would go here (size, cup, ...)
            return beverage;
        }

        // The factory method
        protected abstract Beverage CreateBeverage(CoffeeMix mix);
    }
}
