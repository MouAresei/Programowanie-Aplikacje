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

            Player player = new Player();

            char direction = 's';

            while (true)
            {
                player.Move();
                if(board.CollisionDetect(player.CurrX, player.CurrY))
                {
                    break;
                }

                Thread.Sleep(500);
            }


        }
    }
}
