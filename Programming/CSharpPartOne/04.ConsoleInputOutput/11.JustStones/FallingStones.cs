//* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the
//bottom of the screen and can move left and right (by the arrows keys). A number of rocks 
//of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate 
//density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustStones
{
    struct Stone
    {
        public int x;
        public int y;
        public int size;
        public char c;
        public ConsoleColor color;
    }

    class FallingStones
    {

        static int positionDwarf = 0;
        static int endOfField = 40;
        static int livesCount = 5;
        static Random randomGenerator = new Random();
        static int result = 0;

        static void RemoveScrollBars()
        {
            Console.WindowWidth = 50;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        static void SetInitialPosition()
        {
            positionDwarf = endOfField / 2 - 1;
        }

        static void PrintAtPosition(int x, int y,
                                    ConsoleColor color, char symbol, int size = 1)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            if (size > 1 && x + size <= endOfField)
            {
                for (int i = 1; i < size; i++)
                {
                    Console.SetCursorPosition(x + i, y);
                    Console.Write(symbol);
                }
            }
        }

        static void PrintNumberAtPosition(int x, int y, int number)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(number);
        }

        static void MoveDwarfRight()
        {
            if (positionDwarf < endOfField - 3)
            {
                positionDwarf++;
            }
        }

        static void MoveDwarfLeft()
        {
            if (positionDwarf > 0)
            {
                positionDwarf--;
            }
        }

        static void DrawDwarf()
        {
            PrintAtPosition(positionDwarf, Console.WindowHeight - 1, ConsoleColor.White, '(');
            PrintAtPosition(positionDwarf + 1, Console.WindowHeight - 1, ConsoleColor.White, '0');
            PrintAtPosition(positionDwarf + 2, Console.WindowHeight - 1, ConsoleColor.White, ')');
        }


        static void Main(string[] args)
        {
            RemoveScrollBars();
            SetInitialPosition();
            List<Stone> stones = new List<Stone>();
            ConsoleColor[] stoneColor = new ConsoleColor[15];
            stoneColor[0] = ConsoleColor.Blue;
            stoneColor[1] = ConsoleColor.Cyan;
            stoneColor[2] = ConsoleColor.DarkBlue;
            stoneColor[3] = ConsoleColor.DarkCyan;
            stoneColor[4] = ConsoleColor.DarkGray;
            stoneColor[5] = ConsoleColor.DarkGreen;
            stoneColor[6] = ConsoleColor.DarkMagenta;
            stoneColor[7] = ConsoleColor.DarkRed;
            stoneColor[8] = ConsoleColor.DarkYellow;
            stoneColor[9] = ConsoleColor.Gray;
            stoneColor[10] = ConsoleColor.Green;
            stoneColor[11] = ConsoleColor.Magenta;
            stoneColor[12] = ConsoleColor.Red;
            stoneColor[13] = ConsoleColor.White;
            stoneColor[14] = ConsoleColor.Yellow;
            char[] stoneSymbol = new char[11];
            stoneSymbol[0] = '^';
            stoneSymbol[1] = '@';
            stoneSymbol[2] = '*';
            stoneSymbol[3] = '&';
            stoneSymbol[4] = '+';
            stoneSymbol[5] = '%';
            stoneSymbol[6] = '$';
            stoneSymbol[7] = '#';
            stoneSymbol[8] = '!';
            stoneSymbol[9] = '.';
            stoneSymbol[10] = ';';

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarfRight();
                    }
                }
                bool hitted = false;
                Stone aStone = new Stone();
                int randomColor = randomGenerator.Next(0, 15);
                int randomSymbol = randomGenerator.Next(0, 11);
                aStone.color = stoneColor[randomColor];
                aStone.c = stoneSymbol[randomSymbol];
                aStone.x = randomGenerator.Next(0, endOfField);
                aStone.y = 0;
                aStone.size = randomGenerator.Next(0, 4);
                stones.Add(aStone);

                List<Stone> newList = new List<Stone>();
                for (int i = 0; i < stones.Count; i++)
                {
                    Stone oldStone = stones[i];
                    Stone newStone = new Stone();
                    newStone.x = oldStone.x;
                    newStone.y = oldStone.y + 1;
                    newStone.c = oldStone.c;
                    newStone.size = oldStone.size;
                    newStone.color = oldStone.color;
                    if (newStone.y == Console.WindowHeight - 1 && newStone.x >= positionDwarf
                        && newStone.x < positionDwarf + 3)
                    {

                        livesCount--;
                        hitted = true;
                    }
                    if (newStone.size > 1 && newStone.x + newStone.size >= positionDwarf
                           && newStone.x + newStone.size < positionDwarf + 3
                           && newStone.y == Console.WindowHeight - 1)
                    {
                        livesCount--;
                        hitted = true;
                    }
                    if (newStone.y < Console.WindowHeight)
                    {
                        newList.Add(newStone);
                    }
                }
                stones = newList;
                Console.Clear();
                DrawDwarf();
                if (hitted == true)
                {
                    stones.Clear();
                    PrintAtPosition(positionDwarf, Console.WindowHeight - 1, ConsoleColor.Red, 'X', 3);
                    //Console.WriteLine(livesCount);
                    //Console.ReadKey();
                }
                foreach (Stone stone in stones)
                {
                    PrintAtPosition(stone.x, stone.y, stone.color, stone.c, stone.size);
                }

                if (livesCount >= 1)
                {
                    for (int i = 0; i < livesCount; i++)
                    {
                        PrintAtPosition(49, i, ConsoleColor.Red, '♥');
                        result++;
                        PrintNumberAtPosition(41, 0, result);
                    }

                }
                else
                {
                    PrintNumberAtPosition(41, 0, result);
                    PrintAtPosition(0, 0, ConsoleColor.Red, ' ');
                    Console.WriteLine(" GAME OVER!");
                    Console.WriteLine("Press [Enter] to exit");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                Thread.Sleep(150);
            }
        }
    }
}
