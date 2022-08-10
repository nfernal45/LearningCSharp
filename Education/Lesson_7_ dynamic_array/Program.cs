namespace Lesson_7__dynamic_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("123");
            Console.WriteLine(list.Count());
            //Console.WriteLine(list[1]);
            list.Remove("123");
            Console.WriteLine(list.Count());



        }
    }
}