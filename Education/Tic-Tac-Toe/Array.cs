using System;
namespace Tic_Tac_Toe;

    class Array
    {
   public static string[,] array = new string[Program.arrayX, Program.arrayY];
   static int count = 1;
   static int count2 = 1;
   public static int firstout = 0;

    public static void ArrayGame(int x, int y)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                count2++;
                if (firstout == 0)
                {
                    array[i, j] = $"{count}";
                    count++;
                    if (count < 11)
                        Console.Write($"| {array[i, j]} | ");
                    else                    
                        Console.Write($"| {array[i, j]}| ");                   
                }
                else
                {                    
                    if (array[i,j] == "X" || array[i,j] == "O")
                        Console.Write($"| {array[i, j]} | ");
                     else if (count2 < 11)
                        Console.Write($"| {array[i, j]} | ");
                     else
                        Console.Write($"| {array[i, j]}| ");
                }
            }
            Console.WriteLine();
        }
        firstout++;
        count2 = 1;
        count = 1;
    }
}
