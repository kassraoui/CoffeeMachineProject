using System.Collections.Generic;

namespace CoffeeMachine
{
    public static class DrinkMakerInterpreter
    {
        private static readonly IDictionary<DrinkType, double> costByDrink = new Dictionary<DrinkType, double>
        {
            {DrinkType.C, 0.6},
            {DrinkType.H, 0.5},
            {DrinkType.T, 0.4}
        };
        public static string Send(UserCommand userCommand)
        {
            var sugarsString = userCommand.NbrOfSugars == 0 ? string.Empty : userCommand.NbrOfSugars.ToString();
            var sticksString = userCommand.WithStick ? "0" : string.Empty;
            if (userCommand.InsertedMoney >= costByDrink[userCommand.DrinkType])
                return $"{userCommand.DrinkType}:{sugarsString}:{sticksString}";
            return $"M:Please insert {costByDrink[userCommand.DrinkType] - userCommand.InsertedMoney} €";
        }
    }
}
