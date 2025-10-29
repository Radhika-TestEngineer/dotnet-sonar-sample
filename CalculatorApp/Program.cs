using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"Sum: {calc.Add(10, 5)}");
        }
    }
}
