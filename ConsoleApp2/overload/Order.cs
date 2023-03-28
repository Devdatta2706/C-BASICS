/*using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.overload
{
    internal class Order
    {
        int oid;
        int quant;
        Menue m;

        public vOrder(Menue m, int oid, int quant)
        {
            this.oid = oid;
            this.quant = quant;
            this.m = m;
        }


        public void Show()
        {
            Console.WriteLine(oid + " " + quant);
            Menue M = new Menue(101, "Dosa", 5);
            M.ShowMenue();

        }
        class Menue
        {
            int mid;
            string item;
            double price;

            public Menue(int mid, string item, double price)
            {
                this.mid = mid;
                this.item = item;
                this.price = price;
            }

            public void ShowMenue()
            {
                Console.WriteLine(mid+ " " + item+" "+price+"rs");
            }

            static void Main(string[] args)
            {
                Menue M=new Menue(101,"dosa",5);
                Order o = new Order(M, 1, 1);
                o.Show();
            }
        }
    }
}
*/