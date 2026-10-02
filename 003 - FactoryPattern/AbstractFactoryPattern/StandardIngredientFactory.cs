using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Condiments;

namespace AbstractFactoryPattern
{
    // Concrete factory: the standard ingredients and prices.
    internal class StandardIngredientFactory : ICoffeeIngredientFactory
    {
        public Beverage CreateEspresso(Beverage? beverage = null) => new Espresso(beverage!);
        public Beverage CreateChocolate(Beverage? beverage = null) => new Chocolate(beverage!);
        public Beverage CreateWater(Beverage? beverage = null) => new Water(beverage!);
        public Beverage CreateMilkFoam(Beverage? beverage = null) => new MilkFoam(beverage!);
        public Beverage CreateSteamedMilk(Beverage? beverage = null) => new SteamedMilk(beverage!);
        public Beverage CreateMilk(Beverage? beverage = null) => new Milk(beverage!);
        public Beverage CreateHalfMilk(Beverage? beverage = null) => new HalfMilk(beverage!);
        public Beverage CreateLiqour(Beverage? beverage = null) => new Liqour(beverage!);
        public Beverage CreateWhip(Beverage? beverage = null) => new Whip(beverage!);
        public Beverage CreateLemon(Beverage? beverage = null) => new Lemon(beverage!);
        public Beverage CreateBlackChocolate(Beverage? beverage = null) => new BlackChocolate(beverage!);
        public Beverage CreateWhiteChocolate(Beverage? beverage = null) => new WhiteChocolate(beverage!);
        public Beverage CreateVanillaSugar(Beverage? beverage = null) => new VanillaSugar(beverage!);
        public Beverage CreateCream(Beverage? beverage = null) => new Cream(beverage!);
        public Beverage CreateHoney(Beverage? beverage = null) => new Honey(beverage!);
        public Beverage CreateIceCream(Beverage? beverage = null) => new IceCream(beverage!);
        public Beverage CreateIce(Beverage? beverage = null) => new Ice(beverage!);
        public Beverage CreateSyrup(Beverage? beverage = null) => new Syrup(beverage!);
        public Beverage CreateWhiskey(Beverage? beverage = null) => new Whiskey(beverage!);
    }
}
