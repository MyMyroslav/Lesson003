using System;

namespace Lesson003_Task1_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string c = Console.ReadLine();
            int c2 = int.Parse(c);
            switch (c)
            {
                case "1":
                    {
                        string name1 = "Hat";
                        double price1 = 23.2;
                        Console.WriteLine(name1 + " " + price1);
                        break;
                    }
                case "2":
                    {
                        string name1 = "Denim";
                        double price1 = 2312.2;
                        Console.WriteLine(name1 + " " + price1);
                        break;
                    }
                case "3":
                    {
                        string name1 = "T_Shirt";
                        double price1 = 23.2;
                        Console.WriteLine(name1 + " " + price1);
                        break;
                    }
                case "4":
                    {
                        string name1 = "Sneakers";
                        double price1 = 231.2;
                        Console.WriteLine(name1 + " " + price1);
                        break;
                    }
                case "5:
                    {
                        string name1 = "Shirt";
                        double price1 = 233.2;
                        Console.WriteLine(name1 + " " + price1);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("We do not have this item");
                        break;
                    }
            }
        }
    }
}
