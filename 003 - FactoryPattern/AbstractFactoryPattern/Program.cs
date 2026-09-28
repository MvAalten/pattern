using AbstractFactoryPattern.Beverages;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory factory = new CoffeeFactory();

            foreach (CoffeeMix mix in Enum.GetValues(typeof(CoffeeMix)))
            {
                Beverage beverage = factory.CreateBeverage(mix);
                PrintBeverage(mix, beverage);
            }
        }

        static void PrintBeverage(CoffeeMix mix, Beverage beverage)
        {
            Console.WriteLine(mix + ": " + beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
