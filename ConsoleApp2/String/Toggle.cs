using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    class Toggle
    {

        public static void ChangeCase(string str)
        {
            string toggletest = "";
            for(int i=0;i<str.Length;i++) 
            {
                if (str[i] >= 'A' && str[i]<='Z')
                {
                    toggletest = toggletest + (char)(str[i]+32);

                }
                else if (str[i]>='a' && str[i]<='z')
                {
                    toggletest= toggletest + (char)(str[i]-32);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s= Console.ReadLine();
            Toggle.ChangeCase(s);
            
        }
    }
}
