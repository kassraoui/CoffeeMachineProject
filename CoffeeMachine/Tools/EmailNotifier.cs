namespace CoffeeMachine.Tools
{
    public interface IEmailNotifier
    {
        void NotifyMissingDrink(string drink);
    }
}
