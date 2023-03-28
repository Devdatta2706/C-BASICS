using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class Demo1
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'b', 'c','d' };
            for(int i=chars.Length-1; i>=0; i--) 
            {
                Console.WriteLine(chars[i]);
            
            }
            Console.WriteLine(string.Join(" ", chars));
            int j = chars.Length - 1;
            for(int i=0;i<chars.Length/2;i++) 
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(' ', chars));
        }
    }
}
