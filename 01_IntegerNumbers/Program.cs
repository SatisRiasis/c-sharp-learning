using System;

namespace _01_IntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Console.WriteLine("===INITIALIZATION AND VARIABLES OUTPUT===");

            int firstNumber = 8;
            int secondNumber = 67;
            int thirdNumber = 67;
            long fileSize = 42000000000L;
            short fridgeT = -69;
            byte colorGreen = 95;

            Console.WriteLine($"int firstNumber = {firstNumber}");
            Console.WriteLine($"int secondNumber = {secondNumber}");
            Console.WriteLine($"int thirdNumber = {thirdNumber}");
            Console.WriteLine($"long fileSize = {fileSize}");
            Console.WriteLine($"short fridgeT = {fridgeT}");
            Console.WriteLine($"byte colorGreen = {colorGreen}\n");

            //Arithmetic
            Console.WriteLine("===INTEGER ARITHMETIC===");
            Console.WriteLine($"firstNumber + secondNumber = {firstNumber + secondNumber}");
            Console.WriteLine($"fileSize - colorGreen = {fileSize - colorGreen}");
            Console.WriteLine($"fridgeT * firstNumber = {fridgeT * firstNumber}");
            Console.WriteLine($"fileSize / secondNumber = {fileSize / secondNumber}");
            Console.WriteLine($"fileSize % secondNumber = {fileSize % secondNumber}\n");

            //Increment/Decrement
            Console.WriteLine("===INCREMENT AND DECREMENT===");
            Console.WriteLine($"firstNumber++ = {firstNumber++}");
            Console.WriteLine($"firstNumber after post-increment = {firstNumber}");
            Console.WriteLine($"++firstNumber = {++firstNumber}");
            Console.WriteLine($"firstNumber after pre-increment = {firstNumber}");
            Console.WriteLine($"firstNumber-- = {firstNumber--}");
            Console.WriteLine($"firstNumber after post-decrement = {firstNumber}");
            Console.WriteLine($"--firstNumber = {--firstNumber}");
            Console.WriteLine($"firstNumber after pre-decrement = {firstNumber}\n");

            //Comparison
            Console.WriteLine("===COMPARISON===");
            Console.WriteLine($"secondNumber > firstNumber = {secondNumber > firstNumber}");
            Console.WriteLine($"secondNumber < thirdNumber = {secondNumber < thirdNumber}");
            Console.WriteLine($"firstNumber == thirdNumber = {firstNumber == thirdNumber}");
            Console.WriteLine($"secondNumber != thirdNumber = {secondNumber != thirdNumber}");
            Console.WriteLine($"thirdNumber >= secondNumber = {thirdNumber >= secondNumber}");
            Console.WriteLine($"firstNumber <= secondNumber = {firstNumber <= secondNumber}\n");

            //Using Math class
            Console.WriteLine("===MATH CLASS BASIC METHODS===");
            Console.WriteLine($"Absolute value of fridgeT = {Math.Abs(fridgeT)}");
            Console.WriteLine($"Minimum of firstNumber and fridgeT = {Math.Min(firstNumber, fridgeT)}");
            Console.WriteLine($"Maximum of firstNumber and fridgeT = {Math.Max(firstNumber, fridgeT)}");
            Console.WriteLine($"Squaring firstNumber = {Math.Pow(firstNumber, 2)}");
            Console.WriteLine($"Taking the square root of firstNumber = {Math.Sqrt(firstNumber)}");
            Console.WriteLine($"Sign of fridgeT = {Math.Sign(fridgeT)}");
            Console.WriteLine($"Sign of fileSize = {Math.Sign(fileSize)}\n");

            //Explicit conversion
            Console.WriteLine("===TYPE CASTING===");

            int intFS = (int)fileSize;

            Console.WriteLine($"Cast fileSize from long to int (data loss) = {intFS}");

            byte byteFS = (byte)fileSize;

            Console.WriteLine($"Cast fileSize from long to byte (data loss) = {byteFS}\n");
        }
    }
}
