using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Anagram
    {
        public static void CheckAnagram(string str1,string str2)
        {
            string st1=str1.ToLower();
            string st2=str2.ToLower();
            Console.WriteLine(st1+ " " + st2);

            char[]ch1= st1.ToCharArray();
            char[]ch2= st2.ToCharArray();

            for(int i=0;i<ch1.Length;i++)
            {
                for(int j=0;j<ch1.Length;j++)
                {
                    if (ch1[i] < ch1[j])
                    {
                        int temp = ch1[i];
                        ch1[i] = ch1[j];
                        ch1[j]=(char)temp;
                    }
                }
                for (int j = 0; j < ch2.Length; j++)
                {
                    if (ch1[i] < ch1[j])
                    {
                        int temp = ch2[i];
                        ch2[i] = ch1[j];
                        ch2[j] = (char)temp;
                    }
                }
            }
            string s1=new string(ch1);
            string s2=new string(ch2);
            Console.WriteLine(s1+ " " + s2);

            if(s1==s2)
            {
                Console.WriteLine("Both are Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str1=(Console.ReadLine());
            Console.WriteLine("Enter Anagram string");
            string str2=(Console.ReadLine());
            Anagram.CheckAnagram(str1, str2);

        }
    }
}
