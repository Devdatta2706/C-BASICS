using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    class Lowercase
    {
        public static void small(string str)
        {
            string toggletest = "";
            for(int i=0;i<str.Length;i++)
            {
                if (str[i]>='a' && str[i]<='z')
                {
                    toggletest = toggletest + (char)(str[i] - 32);

                }
                else if (str[i]>='A' && str[i]<='Z')
                {
                    toggletest=toggletest + (char)(str[i]+ 32);
                }
                else
                {
                    toggletest = toggletest + str[i];
                }
            }
            Console.WriteLine(toggletest);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str=Console.ReadLine();
            Lowercase.small(str);
        }
    }
}
