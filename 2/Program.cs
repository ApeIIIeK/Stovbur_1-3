using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите букву первого поля:");
            string firstx = Console.ReadLine();
            char x1 = firstx[0];
            Console.WriteLine("Введите цифру первого поля:");
            string firsty = Console.ReadLine();
            char y1 = firsty[0];
            Console.WriteLine("Введите букву второго поля:");
            string secondx = Console.ReadLine();
            char x2 = secondx[0];
            Console.WriteLine("Введите цифру второго поля:");
            string secondy = Console.ReadLine();
            char y2 = secondy[0];
            if (IsValidChess(x1) && IsValidChess2(y1)&& IsValidChess(x2) && IsValidChess2(y2))
            {

            
            bool sameColor = ((x1 - 'a' + y1 - '1') % 2 == (x2 - 'a' + y2 - '1') % 2);

            Console.WriteLine("Поля {0}{1} и {2}{3} являются полями {4} цвета.",
            x1, y1, x2, y2, sameColor ? "одного" : "разного");

            int size = 8;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   ");
            for (char j = 'a'; j <= 'h'; j++)
            {
                Console.Write(j + "  ");
            }
            Console.WriteLine();

            for (int i = size; i >= 1; i--)
            {
                Console.Write(i + " ");
                for (char j = 'a'; j <= 'h'; j++)
                {
                    if ((j - 'a' + i) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("\u001b[37m B "); // черное поле
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("\u001b[30m W "); // белое поле
                    }
                }
                Console.WriteLine("\u001b[0m");
            }
            Console.BackgroundColor = ConsoleColor.Black;

            }
            else
            {
                Console.WriteLine("Некорректные данные. Введите заново");
            }
        }


        static bool IsValidChess(char coordinate)
        {
            return coordinate >= 'a' && coordinate <= 'h';
        }
        static bool IsValidChess2(char coordinate)
        {
            return coordinate >= '1' && coordinate <= '8';
        }
    }
}
