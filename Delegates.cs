using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Delegate;
namespace cs
{
    public delegate T1 representative<T1, T2>(T1 value, T2 meaning);
    public class Calculator
    {
        public int sum(int value, int meaning)
        {
            return value + meaning;
        }
        public int subtraction(int value, int meaning)
        {
            return value - meaning;
        }
        public int multiplication(int value, int meaning)
        {
            return value * meaning;
        }
        public int division(int value, int meaning)
        {
            return value / meaning;
        }
    }
    internal class Delegates
    {
        static void Main(string[] args)
        {
            representative <int, int> spokesman = null;
            Calculator calculator = new Calculator();
            spokesman = calculator.sum;
            spokesman += calculator.subtraction;
            spokesman += calculator.multiplication;
            spokesman += calculator.division;
            foreach (representative<int, int> item in spokesman.GetInvocationList()) WriteLine($"{item(3, 6)}");
        }
    }
}