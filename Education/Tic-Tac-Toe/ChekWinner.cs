using System;
namespace Tic_Tac_Toe;

public class ChekWin
{
    public static void ChekWinner3(int x, int y)
    {

           ChekHorizontal(x, y);
        if (Program.countStep > Array.array.Length - 1)
            ChekDraw();
        else Program.TestGame();
    }

    static void ChekHorizontal(int x, int y)
    {

        int count = 0;

        for (int i = 0; i < Program.arrayY && count < 3; i++)
            if (Array.array[x, i] == Program.step)
                count++;
            else count = 0;
        if (count == 3)
            ViewWinner.Winner();

        ChekVertical(x, y);

    }

    static void ChekVertical(int x, int y)
    {

        int count = 0;

        for (int i = 0; i < Program.arrayY; i++)
            if (Array.array[i, y] == Program.step)
            {
                count++;
                if (count == 3)
                    ViewWinner.Winner();
            }
            else count = 0;

        ChekCornerLeft(x, y);

    }

    static void ChekCornerLeft(int x, int y)
    {
        int count = 0;

        for (int i = x, j = y; i > -1 && j > -1; i--, j--)
        {
            if (Array.array[i, j] == Program.step)
            {
                count++;
                if (count == 3)
                    ViewWinner.Winner();
            }
            else count = 0;

        }
        count = 0;
        for (int i = x, j = y; i != Program.arrayX && j != Program.arrayY; i++, j++)
        {
            if (Array.array[i, j] == Program.step)
            {
                count++;
                if (count == 3)
                    ViewWinner.Winner();
            }
            else count = 0;

        }


        ChekCornerRight(x, y);

    }

    static void ChekCornerRight(int x, int y)
    {
        int count = 0;

        for (int i = x, j = y; i > -1 && j != Program.arrayY; i--, j++)
        {
            if (Array.array[i, j] == Program.step)
            {
                count++;
                if (count == 3)
                    ViewWinner.Winner();
            }
            else count = 0;

        }
        count = 0;
        for (int i = x, j = y;i != Program.arrayX && j > -1; i++, j--)
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
    static void ChekDraw()
    {
        Console.Clear();
        Array.ArrayGame(Program.arrayX, Program.arrayY);
        Console.WriteLine();
        Console.WriteLine("Ничья");
        Console.WriteLine();
        Program.NewGame();
    }

}
