using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Player
    {
        private ConsoleColor backGrounColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.DarkYellow;
        private char playerChar = 'O';

        private int currX = 1;
        private int currY = 1;

        private int prevX = 1;
        private int prevY = 1;

        public int CurrX
        {

            get
            {
                return currX;
            }
        }

        public int CurrY
        {
            get
            {
                return currY;
            }
        }

        public Player()
        {
            Draw();
        }


        public void Move(char direction)
        {
           // var pressKey = Console.ReadKey(true).KeyChar;

            switch (pressKey)
            {
                case moveUp:
                    currY--;
                    break;

                case moveDown:
                    currY++;
                    break;

                case moveRight:
                    currX++;
                    break;

                case moveLeft:
                    currX--;
                    break;
                default:
                    break;
            }
            Draw();
        }


        private void Draw()
        {
            Console.ResetColor();
            Console.SetCursorPosition(prevX, prevY);
            Console.Write(' ');

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGrounColor;
            Console.SetCursorPosition(currX, currY);
            Console.Write(playerChar);

            prevX = currX;
            prevY = currY;

            Console.ResetColor();
        }
    }
}
