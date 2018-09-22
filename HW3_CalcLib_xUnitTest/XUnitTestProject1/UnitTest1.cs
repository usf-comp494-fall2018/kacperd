using System;
using Xunit;
using CalculatorLib;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        //addition tests
        [Fact]
        public void AddTest_Add0And1()
        {
            // arrange
            double a = 0;
            double b = 1;
            double expected = 1;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTest_Add5AndNegative5()
        {
            // arrange
            double a = 5;
            double b = -5;
            double expected = 0;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }


        //subtraction tests
        [Fact]
        public void SubtTest_Subt1From0()
        {
            // arrange
            double a = 0;
            double b = 1;
            double expected = -1;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Subtract(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtTest_Subt5From7()
        {
            // arrange
            double a = 7;
            double b = 5;
            double expected = 2;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Subtract(a, b);
            // assert
            Assert.Equal(expected, actual);
        }


        //multiplication tests
        [Fact]
        public void MultTest_Mult1And0()
        {
            // arrange
            double a = 1;
            double b = 0;
            double expected = 0;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Multiply(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultTest_Mult2And3()
        {
            // arrange
            double a = 2;
            double b = 3;
            double expected = 6;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Multiply(a, b);
            // assert
            Assert.Equal(expected, actual);
        }


        //division tests
        [Fact]
        public void DivTest_Div10by5()
        {
            // arrange
            double a = 10;
            double b = 5;
            double expected = 2;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Divide(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivTest_Div1by4()
        {
            // arrange
            double a = 1;
            double b = 4;
            double expected = .25;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Divide(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

    }
}
