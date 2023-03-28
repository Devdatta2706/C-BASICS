using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOP
{
    class Use1
    {
        private int num;

        public void  Input(int num)
        {
            this.num = num;

        }
        public void Display()
        {
            Console.WriteLine(num);
        }
    }

    internal class key
    {
        static void Main(string[] args)
        {
            Use1 use = new Use1();
        }
    }
}
