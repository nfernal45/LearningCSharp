namespace Tic_Tac_Toe
{
    internal class Program
    {
       public static int ff;
       static String step = "X"; 
       static int countNewGame = 0;
        static int arrayX;
        static int arrayY;

        static void Main(string[] args)
        {
           // Field(true);
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
            if (ff > 4)
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
                    Console.WriteLine();
                    NewGame();
                }
                else if (ff < Array.array.Length) TestGame();

                else
                {
                    Console.Clear();
                    Array.ArrayGame();
                    Console.WriteLine();
                    Console.WriteLine("Ничья");
                    Console.WriteLine();
                    NewGame();
                }
            }
            else TestGame();


        }

        static void NewGame()
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
                ff = 0;
                step = "X";
                Array.firstout = 0;
                TestGame();
            }
            else if (game == "n")
                Console.Clear();

            else
            {
                Console.WriteLine($"Зачем ты нажал {game}? Тестеровщик чтоли?");
                Console.WriteLine();
                countNewGame++;
                NewGame();
            }
            



        }

        static void Field(Boolean rt) //Еще пока не дописал
        {
            if (rt)
            {
                Console.WriteLine("Введи размеры поля. Сначала кол-во столбоцов, потом кол-во строк");
                Console.WriteLine();
                Console.WriteLine("Поле должно быть не менее 3х3");

                Console.WriteLine("Введи количество столбцов");
            }
            string? stolb = Console.ReadLine();



            if (int.TryParse(stolb, out int v))
            {
                Console.WriteLine(v);
                arrayX = v;
            }

            else
            {
            
                Console.WriteLine($"Разве {stolb} это цифра?");
                Console.WriteLine();
                Console.WriteLine("Попытайся еще раз ввести количество столбцов, на этот раз не промахнись");
                Field(false);
            }





        }
    }



}