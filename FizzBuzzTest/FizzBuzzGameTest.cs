using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Test1()
        {
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();

            //then
            Assert.NotNull(fizzBuzzGame);
        }
    }
}