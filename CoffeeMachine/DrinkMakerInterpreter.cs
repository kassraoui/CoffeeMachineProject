namespace CoffeeMachine
{
    public static class DrinkMakerInterpreter
    {
        public static string Send(UserCommand userCommand)
        {
            var sugarsString = userCommand.NbrOfSugars == 0 ? string.Empty : userCommand.NbrOfSugars.ToString();
            var sticksString = userCommand.WithStick ? "0" : string.Empty;
            if (userCommand.InsertedMoney >= userCommand.Drink.Cost)
                return $"{userCommand.Drink.ShortName}:{sugarsString}:{sticksString}";
            return $"M:Please insert {userCommand.Drink.Cost - userCommand.InsertedMoney} €";
        }
    }
}
