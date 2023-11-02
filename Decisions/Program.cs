using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Theo's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3:");
            string UserValue = Console.ReadLine();

            string message = "";

            if (UserValue == "1")
            {
                 message = "You won the grand prize!!";
                
            }
           else if (UserValue == "2")
            {
                 message = "You won the small prize !!!";
                

            }
           else if (UserValue == "3")
            {
                message = "You l ose, you suck";
                
            }
            else
            {
                 message = "Sorry, thats not a valid response.";
                
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Theo's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3:");
            string UserValue = Console.ReadLine();

            string message = (UserValue == "1") ? "Won the Grand Prize" : "loose, You suck";

            Console.WriteLine("You {0}!", message);
            Console.WriteLine("You entered {0}, so you {1}!", UserValue, message);
            Console.ReadLine();
        }
    }
}
