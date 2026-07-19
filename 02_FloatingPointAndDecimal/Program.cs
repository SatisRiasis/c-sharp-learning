using System;

namespace _02_FloatingPointAndDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Console.WriteLine("===INITIALIZATION AND VARIABLES OUTPUT===");

            double firstNumber = 123.45678;
            double secondNumber = -2.5;
            float axisX = 69.67f;
            decimal savings = 100000.420m;
            decimal spendings = 567.88m;

            Console.WriteLine($"double firstNumber = {firstNumber}");
            Console.WriteLine($"double secondNumber = {secondNumber}");
            Console.WriteLine($"float axisX = {axisX}");
            Console.WriteLine($"decimal savings = {savings}");
            Console.WriteLine($"decimal spendings = {spendings}\n");

            //Arithmetic
            Console.WriteLine("===FLOATING-POINT ARITHMETIC===");
            Console.WriteLine($"firstNumber + secondNumber = {firstNumber + secondNumber}");
            Console.WriteLine($"firstNumber - secondNumber = {firstNumber - secondNumber}");
            Console.WriteLine($"firstNumber * secondNumber = {firstNumber * secondNumber}");
            Console.WriteLine($"firstNumber / secondNumber = {firstNumber / secondNumber}");
            Console.WriteLine($"firstNumber % secondNumber = {firstNumber % secondNumber}\n");

            //Rounding
            Console.WriteLine("===ROUNDING METHODS===");
            Console.WriteLine($"Standard rounding axisX = {Math.Round(axisX)}");
            Console.WriteLine($"Rounding firstNumber to two decimal places = {Math.Round(firstNumber, 2)}");
            Console.WriteLine($"Rounding spendings to the nearest ten = {Math.Round(spendings / 10) * 10}");
            Console.WriteLine($"Banker's rounding of secondNumber = {Math.Round(secondNumber)}");
            Console.WriteLine($"Rounding secondNumber away from zero = {Math.Round(secondNumber, MidpointRounding.AwayFromZero)}");
            Console.WriteLine($"Rounding savings down = {Math.Floor(savings)}");
            Console.WriteLine($"Rounding savings up = {Math.Ceiling(savings)}\n");

            //Powers and roots
            Console.WriteLine("===EXPONENTIATION AND ROOTS===");
            Console.WriteLine($"Squaring secondNumber = {Math.Pow(secondNumber, 2)}");
            Console.WriteLine($"Raising secondNumber to the 5th power = {Math.Pow(secondNumber, 5)}");
            Console.WriteLine($"Taking the 5th root of spendings = {Math.Pow((double)spendings, 1.0 / 5.0)}");
            Console.WriteLine($"Taking the square root of spendings = {Math.Sqrt((double)spendings)}");
            Console.WriteLine($"Taking the cube root of spendings = {Math.Cbrt((double)spendings)}\n");

            //Presicion and conversion
            Console.WriteLine("===PRECISION COMPARISON AND EXPLICIT CONVERSION===");

            decimal firstDC = 0.1m;
            decimal secondDC = 0.2m;

            Console.WriteLine($"Decimal firstDC = {firstDC}");
            Console.WriteLine($"Decimal secondDC = {secondDC}\n");

            double sumDB = (double)firstDC + Convert.ToDouble(secondDC);

            Console.WriteLine($"Sum of firstDC and secondDC converted from decimal to double = {sumDB}");

            decimal sumDC = (decimal)sumDB;

            Console.WriteLine($"Sum of firstDC and secondDC cast back from double to decimal = {sumDC}\n");
        }
    }
}
