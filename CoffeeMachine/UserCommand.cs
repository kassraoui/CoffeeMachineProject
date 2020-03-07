namespace CoffeeMachine
{
    public enum DrinkType
    {
        C,
        H,
        T
    }

    public class UserCommand
    {
        public DrinkType DrinkType { get; }
        public int NbrOfSugars { get; }
        public bool WithStick { get; }

        public double InsertedMoney { get; }

        public UserCommand(DrinkType drinkType, int nbrOfSugars, double insertedMoney)
        {
            DrinkType = drinkType;
            NbrOfSugars = nbrOfSugars;
            InsertedMoney = insertedMoney;
            WithStick = nbrOfSugars != 0;
        }
    }
}
