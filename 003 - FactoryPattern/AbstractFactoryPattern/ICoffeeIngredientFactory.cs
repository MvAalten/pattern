using AbstractFactoryPattern.Beverages;

namespace AbstractFactoryPattern
{
    // Abstract Factory: one create method for every base and condiment that can be put in a drink.
    // Each method wraps the beverage that is passed in (decorator style), or starts a new one when null.
    internal interface ICoffeeIngredientFactory
    {
        Beverage CreateEspresso(Beverage? beverage = null);
        Beverage CreateChocolate(Beverage? beverage = null);
        Beverage CreateWater(Beverage? beverage = null);
        Beverage CreateMilkFoam(Beverage? beverage = null);
        Beverage CreateSteamedMilk(Beverage? beverage = null);
        Beverage CreateMilk(Beverage? beverage = null);
        Beverage CreateHalfMilk(Beverage? beverage = null);
        Beverage CreateLiqour(Beverage? beverage = null);
        Beverage CreateWhip(Beverage? beverage = null);
        Beverage CreateLemon(Beverage? beverage = null);
        Beverage CreateBlackChocolate(Beverage? beverage = null);
        Beverage CreateWhiteChocolate(Beverage? beverage = null);
        Beverage CreateVanillaSugar(Beverage? beverage = null);
        Beverage CreateCream(Beverage? beverage = null);
        Beverage CreateHoney(Beverage? beverage = null);
        Beverage CreateIceCream(Beverage? beverage = null);
        Beverage CreateIce(Beverage? beverage = null);
        Beverage CreateSyrup(Beverage? beverage = null);
        Beverage CreateWhiskey(Beverage? beverage = null);
    }
}
