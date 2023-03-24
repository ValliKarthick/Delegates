using System;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Simple Delegate
            //ChangeMethod changeMethodToAdd = new ChangeMethod(SimpleDelegate.AddNumbers);
            //ChangeMethod changeMethodToMultiply = new ChangeMethod(SimpleDelegate.MultiplyNumbers);
            //changeMethodToAdd(25, 25);
            //SimpleDelegate.AddNumbers(25, 25);
            //changeMethodToMultiply(5, 5);
            //SimpleDelegate.MultiplyNumbers(5, 5);


            //Multicasting Delegate
            //UserName SayHello, SayWelcome, SayBoth, SayAnyOne;
            //SayHello = MultiCastDelegate.SayHello;
            //SayWelcome = MultiCastDelegate.SayWelcome;
            //SayBoth = SayHello + SayWelcome;
            //SayAnyOne = SayBoth - SayWelcome;
            //SayHello("Jane");
            //SayWelcome("Ethan");
            //SayBoth("Emma");
            //SayAnyOne("Rahul");

            //Anonymous methods
            int GstPercentage = 18;
            int hundred = 100;
            CalculateGST calculateGST = delegate (int billValue)
            {
                Console.WriteLine((billValue * GstPercentage) / hundred);
            };

            ////Lambda Expressions
            //CalculateGST calculateGSTviaLambda = (billValue) => {
            //    Console.WriteLine((billValue * GstPercentage) / hundred);
            //};
            calculateGST(40);
            //calculateGSTviaLambda(40);

            Console.ReadLine();
        }
    }
}
