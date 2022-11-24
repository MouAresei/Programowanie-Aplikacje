using Gra.Enums;
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

        public Player(int startX, int startY)
        {
            currX = prevX = startX;
            currY = prevY = startY;
            Draw();
        }


        public void Move(MoveDirection direction)
        {
           // var pressKey = Console.ReadKey(true).KeyChar;

            switch (direction)
            {
                case MoveDirection.MOVE_UP:
                    currY--;
                    break;

                case MoveDirection.MOVE_DOWN:
                    currY++;
                    break;

                case MoveDirection.MOVE_RIGHT:
                    currX++;
                    break;

                case MoveDirection.MOVE_LEFT:
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
