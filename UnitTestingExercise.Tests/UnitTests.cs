using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5,5,5,15)]
        [InlineData(3,4,20,27)]
        [InlineData(10,10,10,30)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        [InlineData(10,5,5)]
        [InlineData(3,9,-6)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtractTest = new Calculator();

            //Act
            int actual = subtractTest.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9,9,81)]//Add test data <-------
        [InlineData(-3,-3,9)]
        [InlineData(0, 0,0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiplyTest = new Calculator();

            //Act
            int actual = multiplyTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(15,5,3)]//Add test data <-------
        [InlineData(-9,3,-3)]
        [InlineData(1300, 10,130)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divideTest = new Calculator();

            //Act
            int actual = divideTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
