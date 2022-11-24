using Gra.Enums;
using System;
using System.Threading;

namespace Gra
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Draw();

            AvaibleFields avaibleFields = board.GetRandomAvaibleField();

            Player player = new Player(avaibleFields.X, avaibleFields.Y);

            MoveDirection direction = MoveDirection.MOVE_RIGHT;

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    direction = (MoveDirection)Console.ReadKey(true).KeyChar;
                }

                player.Move(direction);
                if(board.CollisionDetect(player.CurrX, player.CurrY))
                {
                    break;
                }

                Thread.Sleep(300);
            }


        }
    }
}
