using System;

namespace _01_IntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Console.WriteLine("INITIALIZATION");
            int firstNumber = 8;
            Console.WriteLine($"firstNumber = {firstNumber}");
            int secondNumber = 67;
            Console.WriteLine($"secondNumber = {secondNumber}");
            int thirdNumber = 67;
            Console.WriteLine($"thirdNumber = {thirdNumber}");
            long fileSize = 42000000000;
            Console.WriteLine($"fileSize = {fileSize}");
            short fridgeT = -69;
            Console.WriteLine($"fridgeT = {fridgeT}");
            byte colorGreen = 95;
            Console.WriteLine($"colorGreen = {colorGreen}\n");


            //Arithmetics
            Console.WriteLine("ARITHMETICS");
            Console.WriteLine($"firstNumber + secondNumber = {firstNumber + secondNumber}");
            Console.WriteLine($"fileSize - colorGreen = {fileSize - colorGreen}");
            Console.WriteLine($"fridgeT * firstNumber = {fridgeT * firstNumber}");
            Console.WriteLine($"fileSize / secondNumber = {fileSize / secondNumber}");
            Console.WriteLine($"fileSize % secondNumber = {fileSize % secondNumber}\n");


            //Incr/Decr
            Console.WriteLine("IN/DECREMENT");
            Console.WriteLine($"firstNumber++ = {firstNumber++}");
            Console.WriteLine($"firstNumber = {firstNumber}");
            Console.WriteLine($"++firstNumber = {++firstNumber}");
            Console.WriteLine($"firstNumber = {firstNumber}");
            Console.WriteLine($"firstNumber-- = {firstNumber--}");
            Console.WriteLine($"firstNumber = {firstNumber}");
            Console.WriteLine($"--firstNumber = {--firstNumber}");
            Console.WriteLine($"firstNumber = {firstNumber}\n");


            //Comparison
            Console.WriteLine("COMPARISON");
            Console.WriteLine($"secondNumber > firstNumber = {secondNumber > firstNumber}");
            Console.WriteLine($"secondNumber < thirdNumber = {secondNumber < thirdNumber}");
            Console.WriteLine($"firstNumber == thirdNumber = {firstNumber == thirdNumber}");
            Console.WriteLine($"secondNumber != thirdNumber = {secondNumber != thirdNumber}");
            Console.WriteLine($"thirdNumber >= secondNumber = {thirdNumber >= secondNumber}");
            Console.WriteLine($"firstNumber <= secondNumber = {firstNumber <= secondNumber}\n");


            //Using Math
            Console.WriteLine("MATH CLASS");
            Console.WriteLine($"Math.Abs(fridgeT) = {Math.Abs(fridgeT)}");
            Console.WriteLine($"Math.Min(firstNumber, fridgeT) = {Math.Min(firstNumber, fridgeT)}");
            Console.WriteLine($"Math.Max(firstNumber, fridgeT) = {Math.Max(firstNumber, fridgeT)}");
            Console.WriteLine($"Math.Pow(firstNumber, 2) = {Math.Pow(firstNumber, 2)}");
            Console.WriteLine($"Math.Sqrt(firstNumber) = {Math.Sqrt(firstNumber)}");
            Console.WriteLine($"Math.Sign(fridgeT) = {Math.Sign(fridgeT)}");
            Console.WriteLine($"Math.Sign(fileSize) = {Math.Sign(fileSize)}\n");


            //Casting
            Console.WriteLine("TYPE CASTING");
            int intFS = (int)fileSize;
            Console.WriteLine($"(int)fileSize = {intFS}");
            byte byteFS = (byte)fileSize;
            Console.WriteLine($"(byte)fileSize = {byteFS}\n");


            //User numeric summary
            Console.WriteLine("USER NUMERIC SUMMARY");
            int userAge = 22;
            int yearsToRetirement = 65 - userAge;
            Console.WriteLine($"userAge = {userAge}");
            Console.WriteLine($"years to 30 = {30 - userAge}");
            Console.WriteLine($"years to 65 = {yearsToRetirement}");
            Console.WriteLine($"age to the power of 2 = {Math.Pow(userAge, 2)}");
            Console.WriteLine($"the square root of age = {Math.Sqrt(userAge)}");
            Console.WriteLine($"is legal = {userAge > 18}");
        }
    }
}
