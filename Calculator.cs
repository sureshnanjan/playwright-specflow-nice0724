using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }

    public class CalculatorTests
    {
        readonly Calculator calculator = new Calculator();

        public void TestAddition()
        {
            int result = calculator.Add(2, 2);
            Console.WriteLine($"Addition result: {result}");
        }

        public void TestSubtraction()
        {
            int result = calculator.Subtract(4, 2);
            Console.WriteLine($"Subtraction result: {result}");
        }

        public void TestMultiplication()
        {
            int result = calculator.Multiply(2, 3);
            Console.WriteLine($"Multiplication result: {result}");
        }

        public void TestDivision()
        {
            int result = calculator.Divide(6, 3);
            Console.WriteLine($"Division result: {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CalculatorTests testRunner = new CalculatorTests();
            testRunner.TestAddition();
            testRunner.TestSubtraction();
            testRunner.TestMultiplication();
            testRunner.TestDivision();
        }
    }
}