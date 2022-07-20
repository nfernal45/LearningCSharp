namespace FirstProject
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Hello, World!");
            Array(3,3);
            
        }

        public static void Array(int x, int y)
        {
            int[,] array = new int[x, y];
            int count = 1;
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++) 
                {
                    array[i, j] = count ;
                    count++;
                    Write($"| {array[i, j]} | ");
                
                }
                WriteLine();


            }


        }


    }
}