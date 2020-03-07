namespace CoffeeMachine
{
    public static class Interpreter
    {
        public static string Interpret(UserCommand userCommand)
        {
            var sugarsString = userCommand.NbrOfSugars == 0 ? string.Empty : userCommand.NbrOfSugars.ToString();
            var sticksString = userCommand.WithStick ? "0" : string.Empty;
            return $"{userCommand.DrinkType}:{sugarsString}:{sticksString}";
        }
    }
}
