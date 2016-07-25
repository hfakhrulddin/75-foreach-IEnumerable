using System;

namespace forEach
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Testing Tokens by breaking the string into tokens:
            Tokens f = new Tokens("Hello is it-me you are looking for.", new char[] { ' ', '-' });

            foreach (string item in f)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
