using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string afriend = "matthew";
            string secondFriend = "brandon";
            Console.WriteLine($"Hello {afriend} and{secondFriend}");

            Console.WriteLine($"The name {afriend} has {afriend.Length } letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length } letters");
        }
    }
}
