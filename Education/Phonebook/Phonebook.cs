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
       public static List<Subscriber> s = new List<Subscriber>();
        
        public static void AddSuscriber(Subscriber subscriber)
        {
            if (FindSubcriber(subscriber) == null)
            {
                Phonebook.s.Add(subscriber);
                Console.WriteLine("Контакт внесен");
            }
            else
            {
                Console.WriteLine("Контакт уже есть");
            }
        }

        public static Subscriber FindSubcriber(Subscriber subscriber)
        {
            Subscriber t = Phonebook.s.Find(item => item.Name == subscriber.Name);
            
                return t;

        }

        public static void PrintSubscriber(Subscriber subscriber)
        {
            //Console.WriteLine(subscriber.Name);
            Console.WriteLine(subscriber.Number);
            //return subscriber.Name;
        }
        

    }
}
