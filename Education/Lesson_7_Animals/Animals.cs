using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Animals
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set;}
        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual void Eating(string eat)
        {
            Console.WriteLine("Eating");
           
        }

    }
}


