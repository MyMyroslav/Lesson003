using System;

namespace Lesson003_Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string first = "T-Shirt";
            string second = "Denim";
            string third = "Shirt";
            string fourth = "Sneakers";
            string fifth = "Hat";
            Console.WriteLine("Enter item:");
            string c = Console.ReadLine();
            if (c == first)
            {
                Console.WriteLine("Color: Pink " + first + " " + 25+"$");
            }
            else if (c == second)
            {
                Console.WriteLine("Color: Blue " + second + " " + 15 + "$");
            }
            else if (c == third)
            {
                Console.WriteLine("Color: Yellow "+ third + " " + 30 + "$");
            }
            else if (c == fourth)
            {
                Console.WriteLine("Color: Green "+ fourth + " " + 45 + "$");
            }
            else if (c == fifth)
            {
                Console.WriteLine("Color: Purple " +fifth + " " + 67 + "$");
            }
            else
            {
                Console.WriteLine("We do not have this item.");
            }
        }
    }
}
