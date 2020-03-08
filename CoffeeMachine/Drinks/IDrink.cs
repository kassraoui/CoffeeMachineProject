namespace CoffeeMachine.Drinks
{
    public interface IDrink
    {
        string ShortName { get; }
        double Cost { get; }
    }
}
