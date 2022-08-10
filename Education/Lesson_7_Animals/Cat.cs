using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Animals
{
    public class Cats : Animal, ISay
    {
        public bool Wool { get; set; }
        public string Food { get; set; }
        public int Age { get; set; }
        public int Speed
        {
            get { int speed = 14; return speed; }
        }

        public Cats(string name, int weight, bool wool, string eat, int age) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Wool = wool;
            Food = eat;
            Age = age;
        }

        public string Say()
        {
            string say = "Meow-Meow";
            return say;
        }

        public override void Eating(string eat)
        {
            if (eat != Food)
                Console.WriteLine("No, i don'n eat it");
            else Console.WriteLine("Yeaaah, i am eat it");
            
        }

        public void Pat()
        {
            Console.WriteLine("Mrrr-Mrrr");
        }

    }

}
