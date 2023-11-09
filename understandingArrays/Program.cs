using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3; 
            numbers[3] = 4;
            numbers[4] = 5;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */
            /*
            int[] numbers = new int[] { 4, 7, 5, 2 };
           
            for (int i = 0; i < numbers.Length; i++)
            {
                
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            */

            /*
            String[] names = new string[] { "theo", "maddy", "Eddy", "Burnham" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();*/

            string zig = " i hope you have a good day" + "and enjoy yourself";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray) {
                Console.WriteLine(zigChar);
            }
            Console.ReadLine();
        }
    }
}
