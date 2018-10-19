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

        //mean tests
        [Fact]
        public void MeanTest_Mean0And1()
        {
            // arrange
            double[] arr = { 0, 1 };
            double expected = 0.5;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Mean(arr);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MeanTest_Mean_minus10and10and5()
        {
            // arrange
            double[] arr = { -10, 10 ,3 };
            double expected = 1;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Mean(arr);
            // assert
            Assert.Equal(expected, actual);
        }

        //median tests
        [Fact]
        public void MedianTest_Median4And5()
        {
            // arrange
            double[] arr = { 4, 5 };
            double expected = 4.5;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Median(arr);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MedianTest_Median1and2and5()
        {
            // arrange
            double[] arr = { 1, 2, 5 };
            double expected = 2;
            var calc = new CalculatorLib.Calculator();
            // act
            double actual = calc.Median(arr);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
