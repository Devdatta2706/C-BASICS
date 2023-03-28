using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.inheritance
{
    class fruit
    {
        internal string taste = "sweet";

    }

    class orange:fruit
    {
        public void Show()
        {
            Console.WriteLine("orange is "+taste);
        }

    }
    internal class Single
    {
        static void Main(string[] args)
        {
            orange o= new orange();
            o.Show();

        }
    }
}
