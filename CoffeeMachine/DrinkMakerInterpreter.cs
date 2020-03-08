using System.Collections.Generic;
using System.Linq;
using CoffeeMachine.Tools;

namespace CoffeeMachine
{
    public class DrinkMakerInterpreter
    {
        private readonly IList<UserCommand> _allCommands;
        private readonly IBeverageQuantityChecker beverageQuantityChecker;
        private readonly IEmailNotifier emailNotifier;

        public DrinkMakerInterpreter(IEmailNotifier emailNotifier, IBeverageQuantityChecker beverageQuantityChecker)
        {
            this.emailNotifier = emailNotifier;
            this.beverageQuantityChecker = beverageQuantityChecker;
            _allCommands = new List<UserCommand>();
        }

        public string PrintReport()
        {
            var report = string.Join("\n", _allCommands.GroupBy(c => c.Drink.LongName).Select(grp => $"{grp.Key} : {grp.Count()} command(s)"));
            report += $"\nTotal earned money : {_allCommands.Sum(c => c.Drink.Cost)}€";
            return report;
        }
        public string Send(UserCommand userCommand)
        {
            _allCommands.Add(userCommand);
            var sugarsString = userCommand.NbrOfSugars == 0 ? string.Empty : userCommand.NbrOfSugars.ToString();
            var sticksString = userCommand.WithStick ? "0" : string.Empty;
            if (userCommand.InsertedMoney >= userCommand.Drink.Cost)
                return $"{userCommand.Drink.ShortName}:{sugarsString}:{sticksString}";
            return $"M:Please insert {userCommand.Drink.Cost - userCommand.InsertedMoney} €";
        }
    }
}
