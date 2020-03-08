namespace CoffeeMachine.Drinks
{
    public interface IDrink
    {
        string ShortName { get; }
        string LongName { get; }
        double Cost { get; }
    }
}
