using System.Collections.Generic;
namespace Phonebook
{
    internal class Program
    {
        public static int P = 0;
        static void Main()
        {
            Phonebook phonebook = new();
            if (P == 0)
                phonebook.ImportSubscriber();
            Tets(phonebook);

        }

        public static void Tets(Phonebook phonebook)
        {
            Console.WriteLine("Вас приветствует телефонный справочник");
            Console.WriteLine("Что будем деать?");
            Console.WriteLine();
            Console.WriteLine("1 - Внести контакт, 2 - Найти контакт, 3 - Удалить контакт");
            string key = Console.ReadLine();

            if (key == "1")
                AddSub(phonebook);
            else if (key == "2")
                SearchSub(phonebook);
            else if (key == "3")
                DeleteSub(phonebook);

        }

        public static void AddSub(Phonebook phonebook)
        {
            string Name;
            string Number;

            Console.WriteLine("Введите Имя контакта"); 
            Name = Console.ReadLine();

            Console.WriteLine("Введите номер телефона контакта");
            Number = Console.ReadLine();

            Subscriber subscriber = new(Name, Number);

            if (phonebook.AddSuscriber(subscriber) == 1)
                Console.WriteLine("Контакт внесен");
            else Console.WriteLine($"Контакт с таким номером уже есть");
        }

        public static void SearchSub(Phonebook phonebook)
        {
            string Name;
            Console.WriteLine("Введите имя контакта");
            Name = Console.ReadLine();

            Subscriber subscriber = new(Name);

            Subscriber A = phonebook.FindSubcriber(subscriber);
            Console.Clear();
            if (A != null)
            {
                Console.WriteLine($"Имя контакта {A.Name}");
                Console.WriteLine($"Номер телефона {A.Number}");
            }
            else Console.WriteLine("Такого контакта нет");


        }

        public static void DeleteSub(Phonebook phonebook)
        {
            Subscriber A = new();
            string Name;
            string Number;
            Console.WriteLine("Введите Имя контакта который хотите удалить");
            Name = Console.ReadLine();
            Console.WriteLine("Введите Телефон контакта который хотите удалить");
            Number = Console.ReadLine();

            A.Name = Name;
            A.Number = Number;

            if (phonebook.DeleteSubscriber(A) == 1)
                Console.WriteLine("Удаление успешно");
            else
                Console.WriteLine("Что-то пошло не так");
            P++;
            DeleteSubOnFile(A, phonebook);
            Main();
            
            
        }

        public static void DeleteSubOnFile(Subscriber subscriber, Phonebook phonebook)
        {

            phonebook.DeleteSubOnFile(subscriber.Name);
             phonebook.DeleteSubOnFile(subscriber.Number);

        }

    }
    
}