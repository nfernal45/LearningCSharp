namespace Lesson_7_Animals
{
    public abstract class Animal
    {

        public abstract string Name { get; set; }
        public abstract int Weight { get; set; }


        public virtual void Sound()
        {

            Console.WriteLine("Animal say: Never gonna give you up, Never gonna let you down...");

        }

        public void Eat()
        {

            string eat = "grass";
            Console.WriteLine(eat);

        }

        public void Speed()
        {

            int speed = 2;
            Console.WriteLine(speed);

        }

    }


    public class Cats : Animal
    {
        public override string Name { get; set; }
        public override int Weight { get; set; }

        public Cats(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public override void Sound()
        {
            Console.WriteLine("Cats say: May");

        }
    }
}