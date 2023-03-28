using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TwoDarray
{
    class Employees
    {
        public int empid { get; set; }
        public double empsalary { get; set; }
    }
    class Emp1
    
        {
            static void Main(string[] args)
            {
               
                double[] empSalary = { 15000, 22000, 18000, 25000 };

                for (int i = 0; i < empSalary.Length; i++)
                {
                    if (empSalary[i] < 20000)
                    {
                        empSalary[i] *= 1.1;
                    }
                }
                for (int i = 0; i < empSalary.Length; i++)
                {
                    Console.WriteLine("Employee {0} Salary: {1}", i + 1, empSalary[i]);
                }
            }
        }

    }



