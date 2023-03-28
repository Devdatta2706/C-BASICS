using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Abstract
{
    internal interface Info
    {
        public static string brand;
        public static int range;
        public void DisplayInfo();
    }

    internal interface ISpecs : Info
    {
        public static int price;
        public static int power;
        public void ShowInfo();

    }

    internal class Merge : ISpecs
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Name of Brand: " + Info.brand);
            Console.WriteLine("Screen size: " + Info.range);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Price is : " + ISpecs.price);
            Console.WriteLine("Power in CC  is: " + ISpecs.power);
            
        }
    }

    internal class Operate
    {
        static void Main(string[] args)
        {
            Merge m = new Merge();

            Console.WriteLine("Enter the bike brand name = ");
            Info.brand = Console.ReadLine();
            Console.WriteLine("Enter the mileage = ");
            Info.range = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Price = ");
            ISpecs.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Power in CC = ");
            ISpecs.power = int.Parse(Console.ReadLine());
           

            m.DisplayInfo();
            m.ShowInfo();
        }
    }
}