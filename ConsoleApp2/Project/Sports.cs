using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Project
{


class Sport
    {
        public int SportId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    class Program
    {
        List<Sport> sports = new List<Sport>();
        int nextSportId = 1;

        static void Main(string[] args)
        {
            Program program = new Program();

            while (true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add Sport");
                Console.WriteLine("2. Display Sports");
                Console.WriteLine("3. Update Sport");
                Console.WriteLine("4. Delete Sport");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        program.AddSport();
                        break;
                    case 2:
                        program.DisplaySports();
                        break;
                    case 3:
                        program.UpdateSport();
                        break;
                    case 4:
                        program.DeleteSport();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        void AddSport()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Sport sport = new Sport();
            sport.SportId = nextSportId;
            sport.Name = name;
            sport.Type = type;
            sport.Description = description;

            sports.Add(sport);

            Console.WriteLine("Sport added successfully.");
            nextSportId++;
        }

        void DisplaySports()
        {
            if (sports.Count == 0)
            {
                Console.WriteLine("No sports found.");
                return;
            }

            foreach (Sport sport in sports)
            {
                Console.WriteLine($"Sport ID: {sport.SportId}");
                Console.WriteLine($"Name: {sport.Name}");
                Console.WriteLine($"Type: {sport.Type}");
                Console.WriteLine($"Description: {sport.Description}");
                Console.WriteLine();
            }
        }

        void UpdateSport()
        {
            Console.Write("Enter Sport ID to update: ");
            int sportId = int.Parse(Console.ReadLine());

            Sport sport = sports.Find(s => s.SportId == sportId);

            if (sport == null)
            {
                Console.WriteLine("Sport not found.");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            sport.Name = name;
            sport.Type = type;
            sport.Description = description;

            Console.WriteLine("Sport updated successfully.");
        }

        void DeleteSport()
        {
            Console.Write("Enter Sport ID to delete: ");
            int sportId = int.Parse(Console.ReadLine());

            Sport sport = sports.Find(s => s.SportId == sportId);

            if (sport == null)
            {
                Console.WriteLine("Sport not found.");
                return;
            }

            sports.Remove(sport);

            Console.WriteLine("Sport deleted successfully.");
        }
    }

}

