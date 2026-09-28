using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Condiments;
using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
    internal class CoffeeFactory
    {
        private static readonly Dictionary<CoffeeMix, Func<Beverage>> recipes = new()
        {
            { CoffeeMix.Espresso, () => new Espresso() },
            { CoffeeMix.Doppio, () => new Espresso(new Espresso()) },
            { CoffeeMix.Lungo, () => new Water(new Espresso()) },
            { CoffeeMix.Macchiato, () => new MilkFoam(new Espresso()) },
            { CoffeeMix.Corretta, () => new Liqour(new Espresso()) },
            { CoffeeMix.ConPanna, () => new Whip(new Espresso()) },
            { CoffeeMix.Cappuccino, () => new MilkFoam(new SteamedMilk(new Espresso())) },
            { CoffeeMix.Americano, () => new Water(new Water(new Espresso())) },
            { CoffeeMix.CaffeLatte, () => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))) },
            { CoffeeMix.FlatWhite, () => new SteamedMilk(new SteamedMilk(new Espresso())) },
            { CoffeeMix.Romana, () => new Lemon(new Espresso()) },
            { CoffeeMix.Morocchino, () => new MilkFoam(new Chocolate(new Espresso())) },
            { CoffeeMix.Mocha, () => new Whip(new SteamedMilk(new Chocolate(new Espresso()))) },
            { CoffeeMix.Bicerin, () => new Whip(new WhiteChocolate(new BlackChocolate(new Espresso()))) },
            { CoffeeMix.Breve, () => new HalfMilk(new MilkFoam(new Espresso())) },
            { CoffeeMix.RafCoffee, () => new Cream(new VanillaSugar(new Espresso())) },
            { CoffeeMix.MeadRaf, () => new Cream(new Honey(new Espresso())) },
            { CoffeeMix.Galao, () => new MilkFoam(new MilkFoam(new Espresso())) },
            { CoffeeMix.CaffeAffogato, () => new IceCream(new Espresso(new Espresso())) },
            { CoffeeMix.ViennaCoffee, () => new Whip(new Whip(new Espresso(new Espresso()))) },
            { CoffeeMix.Glace, () => new IceCream(new Espresso()) },
            { CoffeeMix.ChocolateMilk, () => new Milk(new Milk(new Chocolate())) },
            { CoffeeMix.DemiCreme, () => new Cream(new Cream(new Espresso(new Espresso()))) },
            { CoffeeMix.LatteMacchiato, () => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))) },
            { CoffeeMix.Freddo, () => new Ice(new Liqour(new Espresso())) },
            { CoffeeMix.Frappuccino, () => new Whip(new SteamedMilk(new Ice(new Espresso()))) },
            { CoffeeMix.CaramelFrappuccino, () => new Syrup(new Cream(new SteamedMilk(new Ice(new Espresso())))) },
            { CoffeeMix.Frappe, () => new IceCream(new SteamedMilk(new SteamedMilk(new Espresso()))) },
            { CoffeeMix.IrishCoffee, () => new Whip(new Whiskey(new Espresso(new Espresso()))) },
        };

        public Beverage CreateBeverage(CoffeeMix mix)
        {
            if (!recipes.TryGetValue(mix, out var recipe))
            {
                throw new ArgumentOutOfRangeException(nameof(mix), mix, "Unknown coffee mix");
            }
            return recipe();
        }
    }
}
