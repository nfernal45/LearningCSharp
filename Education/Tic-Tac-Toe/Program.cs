namespace Tic_Tac_Toe
{
    internal class Program
    {
       public static int ff;
       static String? step; 

        static void Main(string[] args)
        {
            TestGame();

        }
        static void TestGame()
        {
                Console.Clear();
                Console.WriteLine("Welcome to the Super Duper Tic Tac Toe Game!");
                Console.WriteLine("Player 1: X");
                Console.WriteLine("Player 2: O");
                Console.WriteLine();
                if ((ff % 2) == 0)
                    Console.WriteLine($"Player 1 to move, select 1 thorugh {Array.array.Length} from the game board.");
                else
                    Console.WriteLine($"Player 2 to move, select 1 thorugh {Array.array.Length} from the game board.");
                ff++;
                Console.WriteLine();
                Array.ArrayGame();
                Input();
                ChekWinner();           
        }
        static void Input()                 //Ввод с консоли и получение координат массива
        {
            int x = 0;
            int y = 0;
            int? z = 0;
           
            string? userinput = Console.ReadLine();

            int.TryParse(userinput, out int t);

            if (t < (Array.array.Length + 1) && int.TryParse(userinput, out int v))
            {
                for (int i = 0; i < 3 && z != t; i++)
                {                   
                    for (int j = 0; j < 3 && z != t; j++)
                    {
                        y = j;
                        z++;
                    }
                    x = i;
                }
               ChekInput(x, y);             //Вызываем метод проверки
            }
            else
            {
                Console.WriteLine("Будем считать что у тебя рука дернулась или ты просто промахнулся. Попробуй еще раз");
                Input();
            }
        }

        static void ChekInput(int x, int y) //Проверка элемента массива на уже имеющийся ход  
        {
            if (Array.array[x, y] == "X" || Array.array[x, y] == "O")
            {                
                    Console.WriteLine($"Там уже стоит {Array.array[x, y]}");                   
                    Input();                              
            }
            else           
                SetStep(x, y);              //Если все ок вызываем метод записи хода в массив
                       
        }
        static void SetStep(int x, int y)   //Записываем ход в массив, мы молодцы
        {
            if ((ff % 2) == 0)
            {
                Array.array[x, y] = "O";
                step = "O";
            }
            else
            {
                Array.array[x, y] = "X";
                step = "X";
            }
            
        }

        static void ChekWinner()
        {
            if ((Array.array[0, 0] == step && Array.array[0, 1] == step && Array.array[0, 2] == step) ||
                (Array.array[1, 0] == step && Array.array[1, 1] == step && Array.array[1, 2] == step) ||
                (Array.array[2, 0] == step && Array.array[2, 1] == step && Array.array[2, 2] == step) ||
                (Array.array[0, 0] == step && Array.array[1, 0] == step && Array.array[2, 0] == step) ||
                (Array.array[0, 1] == step && Array.array[1, 1] == step && Array.array[2, 1] == step) ||
                (Array.array[0, 2] == step && Array.array[1, 2] == step && Array.array[2, 2] == step) ||
                (Array.array[0, 2] == step && Array.array[1, 1] == step && Array.array[2, 0] == step) ||
                (Array.array[0, 0] == step && Array.array[1, 1] == step && Array.array[2, 2] == step))
            {
                Console.Clear();
                Array.ArrayGame();
                Console.WriteLine();
                Console.WriteLine($"{step} победил");
            }
            else if (ff < Array.array.Length) TestGame();

            else
            {
                Console.Clear();
                Array.ArrayGame();
                Console.WriteLine();
                Console.WriteLine("Ничья");
            }

        }

    }
}