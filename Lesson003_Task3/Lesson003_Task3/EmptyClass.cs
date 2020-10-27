using System;
namespace Lesson003_Task3
{
    public class EmptyClass
    {
        public EmptyClass()
        {
            string c = Console.ReadLine();
            int c2 = int.Parse(c);
            switch (c)
            {
                case "1": 
                    {
                        string name1 = "Hat";
                        double price1 =23.2;
                        Console.WriteLine(name1 + price1);
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
