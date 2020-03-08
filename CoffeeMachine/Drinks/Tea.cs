namespace CoffeeMachine.Drinks
{
    public class Tea : IDrink
    {
        public virtual string ShortName => "T";
        public double Cost => 0.4;
    }
}
