using System;
namespace Tic_Tac_Toe;

public class ChekWin
{
		public static void ChekWinner3(int x, int y)
        {
        Chek1(x,y);
        Program.TestGame();
        }

	static void Chek1(int x, int y) 
    {
        int a;
        int b;
            a = x - 1;
            b = x + 1;

            if (Array.array[a,y] == Program.step && Array.array[b, y] == Program.step)
            ViewWinner.Winner();
        else Chek2(x, y);
   // Вызываем метод отображения победы
    }

    static void Chek2(int x, int y)
    {
        int a = x - 1;
        int b = y + 1;
        int count = 0;
        if (Array.array[x, a] == Program.step)
            count++;
        else Chek3(x, y);

        if (Array.array[x, b] == Program.step)
            count++;
        else Chek3(x, y);

        if (count == 2)
            ViewWinner.Winner();
        // Вызываем метод отображения победы
    }

    static void Chek3(int x, int y)
    {
        int a = x - 1;
        int b = y - 1;
        int count = 0;
        if (Array.array[a, b] == Program.step)
            count++;
        else Chek4(x, y);

        a = x + 1;
        b = y + 1;
        if (Array.array[a, b] == Program.step)
            count++;
        else Chek4(x, y);

        if (count == 2)
            ViewWinner.Winner();
        // Вызываем метод отображения победы
    }

    static void Chek4(int x, int y)
    {
        int a = x - 1;
        int b = y + 1;
        int count = 0;
        if (Array.array[a, b] == Program.step)
            count++;
        //else Chek5(x, y);

        a = x + 1;
        b = y - 1;
        if (Array.array[a, b] == Program.step)
            count++;
       //else Chek5(x, y);

        if (count == 2)
            ViewWinner.Winner();
        // Вызываем метод отображения победы
    }

}
