using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.overload
{
    class Department
    {
        public int did;
        public string dname;

        public Department(int did, string dname)
        {
            this.did = did;
            this.dname = dname;
        }   

        public void DisplayDept()
        {
            Console.WriteLine(did+ " " + dname);
        }
    }

    class Employee
    {
        int id;
        string name;
        Department dept;

        Employee(int id, string name, Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        } 
        public void ShowEmp()
        {
            Console.WriteLine(id+ " " + name);

            dept.DisplayDept();
        }

        static void Main(string[] args)
        {
            Department d = new Department(1, "HR");
            Employee emp = new Employee(101, "Amit",d);

            emp.ShowEmp();


        }
    }
}
