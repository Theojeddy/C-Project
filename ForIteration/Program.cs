using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("we found a 7");
                    break; 
                }
            }
            Console.ReadLine();
        }
    }
}
