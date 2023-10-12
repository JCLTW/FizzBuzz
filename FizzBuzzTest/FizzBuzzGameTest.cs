using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_given_number_when_countoff_given_a_number_not_multiple_of_3_5_7()
        {
            // Given
            int givenNumber = 1;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal(givenNumber.ToString(), result);
        }

        [Fact]
        public void Should_return_the_Fizz_when_countoff_given_a_number_not_multiple_of_3()
        {
            // Given
            int givenNumber = 3;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_the_Buzz_when_countoff_given_a_number_not_multiple_of_5()
        {
            // Given
            int givenNumber = 5;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_the_Whizz_when_countoff_given_a_number_not_multiple_of_7()
        {
            // Given
            int givenNumber = 7;
            // When
            string result = FizzBuzzGame.CountOff(givenNumber);
            // Then
            Assert.Equal("Whizz", result);
        }
    }
}