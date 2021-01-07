using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while(counter < 101010000000000000)
            {
                Console.WriteLine("$ hello world! the counter is: " + counter);
                counter = counter + 1;
                if (counter == 101010000000000000)
                {
                    break;
                }
            }

        }
    }
}
