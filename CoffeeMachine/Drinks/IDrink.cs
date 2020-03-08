namespace CoffeeMachine.Drinks
{
    public interface IDrink
    {
        string ShortName { get; }
        string LongName { get; }
        string NeededBeverage { get; }
        double Cost { get; }
    }
}
