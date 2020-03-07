using NUnit.Framework;

namespace CoffeeMachine.UnitTests
{
    [TestFixture]
    public class InterpreterTests
    {
        [TestCase(DrinkType.T, 1, "T:1:0")]
        [TestCase(DrinkType.H, 0, "H::")]
        [TestCase(DrinkType.C, 2, "C:2:0")]
        public void Test1(DrinkType drinkType, int nbrOfSugars, string expected)
        {
            var userCommand = new UserCommand(drinkType, nbrOfSugars);
            Assert.AreEqual(expected, Interpreter.Interpret(userCommand));
        }
    }
}
