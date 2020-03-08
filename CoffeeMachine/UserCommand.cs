using CoffeeMachine.Drinks;

namespace CoffeeMachine
{
    public class UserCommand
    {
        public IDrink Drink { get; }
        public int NbrOfSugars { get; }
        public bool WithStick { get; }

        public double InsertedMoney { get; }

        public UserCommand(IDrink drink, int nbrOfSugars, double insertedMoney)
        {
            Drink = drink;
            NbrOfSugars = nbrOfSugars;
            InsertedMoney = insertedMoney;
            WithStick = nbrOfSugars != 0;
        }
    }
}
