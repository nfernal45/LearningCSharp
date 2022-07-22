using System;
namespace Tic_Tac_Toe;


public class ViewWinner
{
	public static void Winner()
	{
        Console.Clear();
        Array.ArrayGame(Program.arrayX, Program.arrayY);
        Console.WriteLine();
        Console.WriteLine($"{Program.step} победил");
        Console.WriteLine();
        Program.NewGame();

    }
}
