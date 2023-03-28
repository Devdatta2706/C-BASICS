using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.OOP
{
    class stud
    {
        int id;
        string name;
        int m1, m2, m3;
        int per;

        public void Accept(int sid, string sname, int mk1, int mk2, int mk3)
        {
            id = sid;
            name = sname;
            m1 = mk1;
            m2 = mk2;
            m3 = mk3;
        }
        public void CalculatePercentage()
        {
            per = ((m1 + m2 + m3) * 100) / 300;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(per);
        }



        internal class Percentage
        {
            static void Main(string[] args)
            {
                stud s = new stud();
                s.Accept(1, "neha", 56, 78, 88);
                s.CalculatePercentage();
                s.DisplayDetails();

            }
        }
    }
}
