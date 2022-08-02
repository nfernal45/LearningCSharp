using System.Collections.Generic;
namespace Phonebook
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Телефонный справочник");
            Console.WriteLine();
            Console.WriteLine("1 - Внести контакт, 2 - Найти контакт");
            //Console.WriteLine($"Была введена цифра " + InputKey());
            if (InputKey() == 1)
                AddSubscriber();
            else if (InputKey() == 2)
                FindName();

        }

        public static int InputKey()
        {
            string input = Console.ReadLine();
            int.TryParse(input, out int t);
            return t;
        }

        public static void AddSubscriber()
        {
            string name = InputName();
            string number = InputNumber();
            Subscriber subscriber = new Subscriber(name, number);
            Phonebook.AddSuscriber(subscriber);
            
            Main();
        }

        public static void FindName()
        {
            Console.Clear();
            string name = InputName();
            Subscriber subscriber = new Subscriber(name);
            Subscriber t = Phonebook.FindSubcriber(subscriber);
            if (t != null)
                Phonebook.PrintSubscriber(t);
            

        }

        public static string InputName()
        {
            Console.WriteLine("Введи Имя контакта");
            string name = Console.ReadLine();
            return name;
        }
        
        public static string InputNumber()
        {
            Console.WriteLine("Введи номер телефона контакта");
            var number = Console.ReadLine();
            return number;
        }
    }
    
}