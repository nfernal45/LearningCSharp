using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Animals
{
    internal class Dog : Animal, ISay
    {
       public bool Thoroughbred { get; set; }
       public string Food { get; set; }
       public int Lifetime { get; set; }
        public int Speed
        {
            get { int speed = 40; return speed; }
        }

        public Dog(string name, int weight, int age, bool thoroughbred, string eat, int lifetime) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Thoroughbred = thoroughbred;
            Food = eat;
            Age = age;
            Lifetime = lifetime;
        }

        public override void Eating(string eat)
        {
            if (eat != Food)
                Console.WriteLine("Yeaaah, i am eat it");
            else Console.WriteLine("Yeaaah, i am eat it");

        }

        public void GoodBoy()
        {
            Console.WriteLine("Moves its tail");
        }

        public string Say()
        {
            string say = "Gav-Gav";
            return say;
        }
    }
}
