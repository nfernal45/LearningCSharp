using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Phonebook
{
    public class Phonebook
    {
        private readonly List<string> s = new List<string>();
        string path = @"C:\Users\Gavrilov\Documents\Git\LearningCSharp\Education\Phonebook\book.txt";

        public void AddSuscriber(Subscriber subscriber)
        {

            s.Add(subscriber.Name + " " + subscriber.Number);
            ;
            File.WriteAllLines(path, s);
            Console.WriteLine("Контакт внесен");
            Console.WriteLine(FindSubcriber(subscriber));



        }

        public string FindSubcriber(Subscriber subscriber)
        {
            string a = subscriber.Name;
            string t = s.Find(item => a == subscriber.Name);

            return t;

        }

        public string PrintSubscriber(Subscriber subscriber)
        {
            //Console.WriteLine(subscriber.Number);
            return subscriber.Name;

        }

    }
}


