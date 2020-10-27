using System;

namespace Lesson003_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string num = Console.ReadLine();
            int num2 = int.Parse(num);
            if((num2 % 2) == 0)
            {
                Console.WriteLine("Parnuy");
            }
            else
            {
                Console.WriteLine("Ne Parnuy");
            }
            
            
        }
    }
}
