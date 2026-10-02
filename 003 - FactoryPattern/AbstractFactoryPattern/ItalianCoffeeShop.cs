using AbstractFactoryPattern.Beverages;
using AbstractFactoryPattern.Condiments;

namespace AbstractFactoryPattern
{
    // Concrete creator: knows the recipe for every CoffeeMix and gets its ingredients from the ingredient factory.
    internal class ItalianCoffeeShop : CoffeeShop
    {
        private readonly ICoffeeIngredientFactory f;

        public ItalianCoffeeShop(ICoffeeIngredientFactory ingredientFactory)
        {
            f = ingredientFactory;
        }

        protected override Beverage CreateBeverage(CoffeeMix mix)
        {
            switch (mix)
            {
                case CoffeeMix.Espresso: return f.CreateEspresso();
                case CoffeeMix.Doppio: return f.CreateEspresso(f.CreateEspresso());
                case CoffeeMix.Lungo: return f.CreateWater(f.CreateEspresso());
                case CoffeeMix.Macchiato: return f.CreateMilkFoam(f.CreateEspresso());
                case CoffeeMix.Corretta: return f.CreateLiqour(f.CreateEspresso());
                case CoffeeMix.ConPanna: return f.CreateWhip(f.CreateEspresso());
                case CoffeeMix.Cappuccino: return f.CreateMilkFoam(f.CreateSteamedMilk(f.CreateEspresso()));
                case CoffeeMix.Americano: return f.CreateWater(f.CreateWater(f.CreateEspresso()));
                case CoffeeMix.CaffeLatte: return f.CreateMilkFoam(f.CreateSteamedMilk(f.CreateSteamedMilk(f.CreateEspresso())));
                case CoffeeMix.FlatWhite: return f.CreateSteamedMilk(f.CreateSteamedMilk(f.CreateEspresso()));
                case CoffeeMix.Romana: return f.CreateLemon(f.CreateEspresso());
                case CoffeeMix.Morocchino: return f.CreateMilkFoam(f.CreateChocolate(f.CreateEspresso()));
                case CoffeeMix.Mocha: return f.CreateWhip(f.CreateSteamedMilk(f.CreateChocolate(f.CreateEspresso())));
                case CoffeeMix.Bicerin: return f.CreateWhip(f.CreateWhiteChocolate(f.CreateBlackChocolate(f.CreateEspresso())));
                case CoffeeMix.Breve: return f.CreateHalfMilk(f.CreateMilkFoam(f.CreateEspresso()));
                case CoffeeMix.RafCoffee: return f.CreateCream(f.CreateVanillaSugar(f.CreateEspresso()));
                case CoffeeMix.MeadRaf: return f.CreateCream(f.CreateHoney(f.CreateEspresso()));
                case CoffeeMix.Galao: return f.CreateMilkFoam(f.CreateMilkFoam(f.CreateEspresso()));
                case CoffeeMix.CaffeAffogato: return f.CreateIceCream(f.CreateEspresso(f.CreateEspresso()));
                case CoffeeMix.ViennaCoffee: return f.CreateWhip(f.CreateWhip(f.CreateEspresso(f.CreateEspresso())));
                case CoffeeMix.Glace: return f.CreateIceCream(f.CreateEspresso());
                case CoffeeMix.ChocolateMilk: return f.CreateMilk(f.CreateMilk(f.CreateChocolate()));
                case CoffeeMix.DemiCreme: return f.CreateCream(f.CreateCream(f.CreateEspresso(f.CreateEspresso())));
                case CoffeeMix.LatteMacchiato: return f.CreateMilkFoam(f.CreateSteamedMilk(f.CreateSteamedMilk(f.CreateEspresso())));
                case CoffeeMix.Freddo: return f.CreateIce(f.CreateLiqour(f.CreateEspresso()));
                case CoffeeMix.Frappuccino: return f.CreateWhip(f.CreateSteamedMilk(f.CreateIce(f.CreateEspresso())));
                case CoffeeMix.CaramelFrappuccino: return f.CreateSyrup(f.CreateCream(f.CreateSteamedMilk(f.CreateIce(f.CreateEspresso()))));
                case CoffeeMix.Frappe: return f.CreateIceCream(f.CreateSteamedMilk(f.CreateSteamedMilk(f.CreateEspresso())));
                case CoffeeMix.IrishCoffee: return f.CreateWhip(f.CreateWhiskey(f.CreateEspresso(f.CreateEspresso())));
                default: throw new ArgumentOutOfRangeException(nameof(mix), mix, "Unknown coffee mix");
            }
        }
    }
}
