namespace CoffeeMachine.Drinks
{
    public class OrangeJuice : IDrink
    {
        public string ShortName => "O";
        public string LongName => "Orange Juice";
        public string NeededBeverage => "Water";
        public double Cost => 0.6;
    }
}
