namespace CoffeeMachine.Drinks
{
    public class Coffee : IDrink
    {
        public virtual string ShortName => "C";
        public virtual string LongName => "Coffee";
        public double Cost => 0.6;
    }
}
