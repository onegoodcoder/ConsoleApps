using System;

namespace LoopDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }
    }
}
