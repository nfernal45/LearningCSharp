namespace Lesson_7_Animals
{
    internal class Program
    {
        static void Main()
        {
            Cats cat = new("Tom", 4, true, "Whiskas", 8);
            Console.WriteLine(cat.Say);

        }
    }
}