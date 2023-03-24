using System;

namespace Delegates
{
    delegate void UserName(string name);
    public class MultiCastDelegate
    {
        public static void SayHello(string Name)
        {
            Console.WriteLine("Hello:" + Name);
        }

        public static void SayWelcome(string Name)
        {
            Console.WriteLine("Welcome:" + Name);
        }
    }
}
