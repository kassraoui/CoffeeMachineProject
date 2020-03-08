using System.Collections.Generic;
using CoffeeMachine.Drinks;
using NUnit.Framework;

namespace CoffeeMachine.UnitTests
{
    [TestFixture]
    public class InterpreterTests
    {
        private IDictionary<string, IDrink> _allDrinks;
        [SetUp]
        public void Init()
        {
            _allDrinks = new Dictionary<string, IDrink>
            {
                {"coffee", new Coffee()},
                {"tea", new Tea()},
                {"choco", new Chocolate()},
                {"orange", new OrangeJuice()},
                {"coffeeEH", new CoffeeExtraHot()},
                {"teaEH", new TeaExtraHot()},
                {"chocoEH", new ChocoExtraHot()},
            };
        }

        [TestCase("tea", 1, 1, "T:1:0")]
        [TestCase("choco", 0, 1, "H::")]
        [TestCase("coffee", 2, 1, "C:2:0")]
        [TestCase("coffee", 2, 0.1, "M:Please insert 0.5 €")]
        [TestCase("orange", 0, 1, "O::")]
        [TestCase("coffeeEH", 0, 1, "Ch::")]
        [TestCase("chocoEH", 1, 1, "Hh:1:0")]
        [TestCase("teaEH", 2, 1, "Th:2:0")]
        public void SendToCoffeeMakerTest(string drink, int nbrOfSugars, double money, string expected)
        {
            var userCommand = new UserCommand(_allDrinks[drink], nbrOfSugars, money);
            var interpreter = new DrinkMakerInterpreter();
            Assert.AreEqual(expected, interpreter.Send(userCommand));
        }

        [Test]
        public void PrintReportTest()
        {
            var interpreter = new DrinkMakerInterpreter();
            interpreter.Send(new UserCommand(new Chocolate(), 0, 1));
            interpreter.Send(new UserCommand(new OrangeJuice(), 0, 1));


            const string expectedReport = "Chocolate : 1 command(s)\nOrange Juice : 1 command(s)\nTotal earned money : 1.1€";
            Assert.AreEqual(expectedReport, interpreter.PrintReport());
        }
    }
}
