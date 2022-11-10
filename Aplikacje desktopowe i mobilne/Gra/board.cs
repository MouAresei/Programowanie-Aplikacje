using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Board
    {
        private int height = 20;
        private int width = 30;

        private ConsoleColor backGrounColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.DarkYellow;
        private char borderChar = 'X';

        public Board()
        {
            
        }

        public void Draw()
        {
            Console.Clear();

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGrounColor;

            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }
            for (int i = 0; i < height-1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(borderChar);

                Console.SetCursorPosition(height-1, i);
                Console.Write(borderChar);

            }

            Console.SetCursorPosition(0, height-1);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }
            Console.ResetColor();
        }
    }
}
