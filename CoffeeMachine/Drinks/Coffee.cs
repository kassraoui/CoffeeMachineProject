namespace CoffeeMachine.Drinks
{
    public class Coffee : IDrink
    {
        public virtual string ShortName => "C";
        public double Cost => 0.6;
    }
}
