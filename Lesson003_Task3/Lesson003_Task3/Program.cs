using System;

namespace Lesson003_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Рідке,а не вода, біле а не сніг.");
            string answer = "Молоко";
            Console.WriteLine("Відповідь:");
            string intext = Console.ReadLine();
            if(intext == answer)
            {
                Console.WriteLine("Правильно!");
            }
            else
            {
                Console.WriteLine("Неправильно!");
            }
        }
    }
}
