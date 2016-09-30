using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string username = "Jamie";
            Console.WriteLine("Hello " + username);
            SayThis("Object Oriented Programming");
            SayThis("Is awesome!");
        }

        public static void SayThis(string aSentence)
        {
            Console.WriteLine(aSentence);
        }
    }
}
