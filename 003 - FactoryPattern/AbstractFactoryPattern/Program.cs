using AbstractFactoryPattern.Beverages;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop shop = new ItalianCoffeeShop(new StandardIngredientFactory());

            foreach (CoffeeMix mix in Enum.GetValues(typeof(CoffeeMix)))
            {
                Beverage beverage = shop.OrderBeverage(mix);
                PrintBeverage(mix, beverage);
            }
        }

        static void PrintBeverage(CoffeeMix mix, Beverage beverage)
        {
            Console.WriteLine(mix + ": " + beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
