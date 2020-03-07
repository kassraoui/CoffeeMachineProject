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

        public UserCommand(DrinkType drinkType, int nbrOfSugars)
        {
            DrinkType = drinkType;
            NbrOfSugars = nbrOfSugars;
            WithStick = nbrOfSugars != 0;
        }
    }
}
