using System;

namespace Delegates
{
    delegate void ChangeMethod(int numberOne, int numberTwo);
    public static class SimpleDelegate
    {
        public static void AddNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine("Addition Output:"+ (numberOne + numberTwo));
        }
        public static void MultiplyNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine("Multiplication Output:"+ (numberOne * numberTwo));             
        }
    }
}
