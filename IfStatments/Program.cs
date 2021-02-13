using System;

namespace IfStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            bool somthing = a + b >10;
            if (somthing)
            {
                Console.WriteLine("The answer is greater than 10.");
            }

            else
            {
                Console.WriteLine("The answer not greater than 10.");
            }


        }
    }
}
