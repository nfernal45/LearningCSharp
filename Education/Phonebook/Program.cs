using System.Collections.Generic;
namespace Phonebook
{
    internal class Program
    {
        static void Main()
        {
            Phonebook phonebook = new ();

            Subscriber subscriber = new ("Tom", "112");
            Subscriber subscriber2 = new ("Bob", "312");

            phonebook.AddSuscriber(subscriber);
            phonebook.AddSuscriber(subscriber2);
            //Subscriber subscriber3 = new ("Bob");
            
           // Console.WriteLine(phonebook.FindSubcriber(subscriber3).Number);
            
           // System.Console.WriteLine(phonebook.FindSubcriber(subscriber2).Name + phonebook.FindSubcriber(subscriber2).Number);

        }

    }
    
}