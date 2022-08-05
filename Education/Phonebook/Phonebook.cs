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
        private readonly List<Subscriber> s = new List<Subscriber>();
        string path = @"C:\Users\iva\Documents\Git\PS-1\LearningCSharp\Education\Phonebook\book.txt";

        public int AddSuscriber(Subscriber subscriber)
        {
            if (FindSubcriber(subscriber) == null)
            {
                s.Add(subscriber);
                using (StreamWriter writer = new StreamWriter(path, true))
                {

                    writer.WriteLineAsync(subscriber.Name);
                    writer.WriteLineAsync(subscriber.Number);
                    writer.Close();

                }
                return 1;
            }
            else return -1;
        }

        public void ImportSubscriber(string file)
        {
            StreamReader reader = new StreamReader(path);
            string m;
            while ((m = reader.ReadLine()) != file)
            {
                Subscriber A = new Subscriber();
                A.Name = m;
                A.Number = reader.ReadLine();
                s.Add(A);
            }
            reader.Close();
        }

        public Subscriber FindSubcriber(Subscriber subscriber)
        {
            Subscriber t;
            if (subscriber.Number != null)
            {

                t = s.Find(item => item.Number == subscriber.Number);
            }

            else
            {

                t = s.Find(item => item.Name == subscriber.Name);
            }

            return t;
        }

        public int DeleteSubscriber(Subscriber subscriber)
        {
            Subscriber t;
            t = FindSubcriber(subscriber);

            if (s.Remove(t))
                return 1;
            else 
                return -1;
           
        }

        public void DeleteSubOnFile(string subscriber)
        {

            var re = File.ReadAllLines(path, Encoding.Default).Where(s => !s.Contains(subscriber));
            File.WriteAllLines(path, re, Encoding.Default);
             
        }

    }
}


