using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Words
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine();

           
            string[] nameParts = fullName.Split(' ');

            
            string firstNameInitial = nameParts[0][0].ToString();
            string middleNameInitial = (nameParts.Length > 2) ? nameParts[1][0].ToString() : "";
            string lastNameInitial = nameParts[nameParts.Length - 1][0].ToString();

            

            string formattedName = firstNameInitial + "." + middleNameInitial + "." + lastNameInitial + nameParts[nameParts.Length - 1].Substring(1);

            Console.WriteLine("Formatted name: " + formattedName);
        }
    }
}






