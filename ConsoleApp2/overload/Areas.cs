using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.overload
{
    internal class Areas
    {
        public double Area1(int length,int height)
        {
            return 0.5 * length * height;
        }


        public double Area1(double radius)
        {
            return 3.14 * radius * radius;
        }

        public double Area1(int length)
        {
            return length * length;
        }
        
        public double Area1(double length, double width)
        {
            return length * width;
        }
         

        class Program
        {

            public static void Main()
            {
                Areas a = new Areas();

                var triangleArea = a.Area1(5, 8);
                Console.WriteLine("Area of Triangle= "+triangleArea);

                double circleArea = a.Area1(7);
                Console.WriteLine("Area of Circle= " + circleArea);

                double squareArea= a.Area1(6);
                Console.WriteLine("Area of Square= " + squareArea);

                double rectArea = a.Area1(4, 3);
                Console.WriteLine("Area of Rectangle= " + rectArea);
            }
        }
    }
}
