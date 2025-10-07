using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopMiniGame_MasonSeale
{
    internal class Program
    {
        static (int, int) pos = (10, 10);
        static List<(int, int)> visited = new List<(int, int)>();
        static bool going = true;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            while (true)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("I");
                move();
                Console.SetCursorPosition(pos.Item1, pos.Item2);
                if (going == false)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("game over");
                    break;
                }


            }
        }
        static void move()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            visited.Add(pos);
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            Console.Write(" ");
            if (key.Key == ConsoleKey.W)
            {
                pos.Item2 -= 1;
            }
            if (key.Key == ConsoleKey.S)
            {
                pos.Item2 += 1;
            }
            if(key.Key == ConsoleKey.A)
            {
                pos.Item1 -= 1;
            }
            if(key.Key == ConsoleKey.D)
            {
                pos.Item1 += 1;
            }
            if(key.Key == ConsoleKey.Escape)
            {
                endgame();
            }

            if (visited.Contains(pos))
            {
                endgame();
            }
        }
        static void endgame()
        {
            going = false;
        }
        
  
    }
}
