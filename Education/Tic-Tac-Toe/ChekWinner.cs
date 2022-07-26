using System;
namespace Tic_Tac_Toe;

public class ChekWin
{
    static int count = 0;
    public static void ChekWinner3(int x, int y)
    {

           ChekHorizontal(x, y);
        if (Program.countStep > Array.array.Length - 1)
            ChekDraw();
        else Program.TestGame();
    }

    static void ChekHorizontal(int x, int y)
    {
        count = 0;
        for (int i = 0; i < Program.arrayY; i++)
            ChekCount(x, i);

        ChekVertical(x, y);

    }

    static void ChekVertical(int x, int y)
    {
        count = 0;
        for (int i = 0; i < Program.arrayY; i++)
            ChekCount(i, y);

        ChekCornerLeft(x, y);

    }

    static void ChekCornerLeft(int x, int y)
    {
        count = 0;
        for (int i = x, j = y; i > -1 && j > -1; i--, j--)
            ChekCount(i, j);

        count = 0;
        for (int i = x, j = y; i != Program.arrayX && j != Program.arrayY; i++, j++)
            ChekCount(i, j);

        ChekCornerRight(x, y);

    }

    static void ChekCornerRight(int x, int y)
    {
        count = 0;
        for (int i = x, j = y; i > -1 && j != Program.arrayY; i--, j++)
            ChekCount(i, j);

        count = 0;
        for (int i = x, j = y;i != Program.arrayX && j > -1; i++, j--)
            ChekCount(i, j);

    }
    static void ChekDraw()
    {
        Console.Clear();
        Array.ArrayGame(Program.arrayX, Program.arrayY);
        Console.WriteLine();
        Console.WriteLine("Ничья");
        Console.WriteLine();
        Program.NewGame();
    }

    static void ChekCount(int i, int j)
    {
        
        if (Array.array[i, j] == Program.step)
        {
            count++;
            if (count == 3)
                ViewWinner.Winner();
        }
        else count = 0;

    }

}
