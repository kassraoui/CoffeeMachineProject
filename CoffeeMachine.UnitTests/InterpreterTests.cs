using NUnit.Framework;

namespace CoffeeMachine.UnitTests
{
    [TestFixture]
    public class InterpreterTests
    {
        [TestCase(DrinkType.T, 1, 1, "T:1:0")]
        [TestCase(DrinkType.H, 0, 1, "H::")]
        [TestCase(DrinkType.C, 2, 1, "C:2:0")]
        [TestCase(DrinkType.C, 2, 0.1, "M:Please insert 0.5 €")]
        public void Test1(DrinkType drinkType, int nbrOfSugars, double money, string expected)
        {
            var userCommand = new UserCommand(drinkType, nbrOfSugars, money);
            Assert.AreEqual(expected, DrinkMakerInterpreter.Send(userCommand));
        }
    }
}
