using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "You say goodbye, and I say hello";
            bool result = songLyrics.StartsWith("You");
            Console.WriteLine(result);
            
            bool secondResult = songLyrics.EndsWith("hello");
            Console.WriteLine(secondResult);



            bool thirdResult = songLyrics.Contains("and");
            Console.WriteLine(thirdResult);

        }
    }
}
