namespace Tic_Tac_Toe
{
    internal class Program
    {
        public static int countStep;
        public static String step = "X";
        static int countNewGame = 0;
        public static int arrayX;
        public static int arrayY;

        static void Main()
        {
            InputFieldX(true);
            TestGame();

        }
       public static void TestGame()
        {
            Console.Clear();           
            Console.WriteLine();
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine();
            if ((countStep % 2) == 0)
                Console.WriteLine($"Player 1 to move, select 1 thorugh {Array.array.Length} from the game board.");
            else
                Console.WriteLine($"Player 2 to move, select 1 thorugh {Array.array.Length} from the game board.");
            countStep++;
            Console.WriteLine();
            Array.ArrayGame(arrayX, arrayY);
            Input();

        }
        static void Input() 
        {
            int x = 0;
            int y = 0;
            int? z = 0;

            string? userinput = Console.ReadLine();

            int.TryParse(userinput, out int t);

            if (t < (Array.array.Length + 1) && int.TryParse(userinput, out int v))
            {
                for (int i = 0; i < arrayX && z != t; i++)
                {
                    for (int j = 0; j < arrayY && z != t; j++)
                    {
                        y = j;
                        z++;
                    }
                    x = i;
                }
                ChekInput(x, y); 
            }
            else
            {
                Console.WriteLine("Будем считать что у тебя рука дернулась или ты просто промахнулся. Попробуй еще раз");
                Input();
            }
        }

        static void ChekInput(int x, int y) 
        {
            if (Array.array[x, y] == "X" || Array.array[x, y] == "O")
            {
                Console.WriteLine($"Там уже стоит {Array.array[x, y]}");
                Input();
            }
            else
                SetStep(x, y);              

        }
        static void SetStep(int x, int y)   
        {
            if ((countStep % 2) == 0)
            {
                Array.array[x, y] = "O";
                step = "O";
            }
            else
            {
                Array.array[x, y] = "X";
                step = "X";
            }
             if (countStep > 4)
                ChekWin.ChekWinner3(x, y);
            else TestGame();

        }
        public static void NewGame()
        {
            if (countNewGame == 0)
            {
                Console.WriteLine("Еще сыграем? y - да, n - нет");
            }
            else
            {
                Console.WriteLine("y - да, n - нет");
            }
            string game = Console.ReadLine();
            if (game == "y")
            {
                countStep = 0;
                step = "X";
                Array.firstout = 0;
                TestGame();
            }
            else if (game == "n")
            {
                Console.Clear();
                Console.WriteLine("\"Я в своем познании настолько преисполнился,");
                Console.WriteLine(" что я как будто бы уже сто триллионов миллиардов лет проживаю ");
                Console.WriteLine(" на триллионах и триллионах таких же планет, как эта Земля...\"");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine($"Зачем ты нажал {game}? Тестеровщик чтоли?");
                Console.WriteLine();
                countNewGame++;
                NewGame();
            }

        }

        static void InputFieldX(Boolean rt) //Еще пока не дописал
        {
            if (rt)
            {
                Console.WriteLine("Welcome to the Super Duper Tic Tac Toe Game!");
                Console.WriteLine();
                Console.WriteLine("Введи размеры поля. Сначала кол-во столбоцов, потом кол-во строк");
                Console.WriteLine();
                Console.WriteLine("Поле должно быть не менее 3х3");

                Console.WriteLine("Введи количество строк");
            }
            string? stolb = Console.ReadLine();

            if (int.TryParse(stolb, out int v))
            {
                if (v < 3)
                {
                    Console.WriteLine("ПОЛЕ.ДОЛЖНО.БЫТЬ.НЕ.МЕНЕЕ.3х3!!!");
                    InputFieldX(false);
                }
                else
                {
                    Console.WriteLine(v);
                    arrayX = v;
                    Console.Clear();
                    InputFieldY(true);
                }
            }

            else
            {

                Console.WriteLine($"Разве {stolb} это цифра?");
                Console.WriteLine();
                Console.WriteLine("Попытайся еще раз ввести количество столбцов, на этот раз не промахнись");
                InputFieldX(false);
                Console.Clear();
            }

        }

        static void InputFieldY(Boolean rt) 
        {
            if (rt)
            {
                Console.WriteLine("Welcome to the Super Duper Tic Tac Toe Game!");
                Console.WriteLine();
                Console.WriteLine("Поле должно быть не менее 3х3");

                Console.WriteLine("Введи количество солбцов");
            }
            string? stolb = Console.ReadLine();

            if (int.TryParse(stolb, out int v))
            {
                if (v < 3)
                {
                    Console.WriteLine("ПОЛЕ.ДОЛЖНО.БЫТЬ.НЕ.МЕНЕЕ.3х3!!!");
                    InputFieldX(false);
                }
                else
                {
                    Console.WriteLine(v);
                    arrayY = v;
                }
            }

            else
            {

                Console.WriteLine($"Разве {stolb} это цифра?");
                Console.WriteLine();
                Console.WriteLine("Попытайся еще раз ввести количество столбцов, на этот раз не промахнись");
                InputFieldY(false);
                Console.Clear();
            }
        }
    }
}