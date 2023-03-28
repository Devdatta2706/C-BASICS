using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class Reversechar
    {
        static void Main(string[] args)
        {
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };

            //Array.Reverse(chars);

            Console.WriteLine("The reversed array is: " + new string(chars));

        }
    }
}
