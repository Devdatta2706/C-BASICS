using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Count
    {
        public static void CountWords(string str)
        {
            int word = 0;

            for(int i=0;i<=str.Length;i++)
            {
                if (str[i] == ' ') 
                { 
                    word++;
                }
                i++;
            }
            Console.WriteLine("Total Word: " + word);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str= Console.ReadLine();
            Count.CountWords(str);
        }
    }
}
