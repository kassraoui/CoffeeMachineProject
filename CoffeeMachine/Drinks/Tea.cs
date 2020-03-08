namespace CoffeeMachine.Drinks
{
    public class Tea : IDrink
    {
        public virtual string ShortName => "T";
        public virtual string LongName => "Tea";
        public string NeededBeverage => "Water";
        public double Cost => 0.4;
    }
}
