using Gra.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class Board
    {
        private int topCorner = 45;
        private int leftCorner = 5;
        private int height = 20;
        private int width = 30;
        private int percentOfStoneObstacles = 6;

        private ConsoleColor backGrounColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.DarkYellow;
        private char borderChar = 'X';

        private List<AvaibleFields> availbleFieldsOnBoard = new List<AvaibleFields>();

        public Board()
        {
            
        }

        public void Draw()
        {
            Console.Clear();

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGrounColor;

            Console.SetCursorPosition(topCorner, leftCorner );
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }


            for (int i = 0; i < height-1; i++)
            {
                Console.SetCursorPosition(topCorner, i+ leftCorner);
                Console.Write(borderChar);

                Console.SetCursorPosition(width -1 + topCorner, i + leftCorner);
                Console.Write(borderChar);

            }

            Console.SetCursorPosition(topCorner, height-1+ leftCorner);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }
            Console.ResetColor();
        }

        public CollisionType CollisionDetect(int x, int y)
        {
           /* for (int i = 0; i < availbleFieldsOnBoard.Count; i++)
            {
                if (availbleFieldsOnBoard[i].X == x && availbleFieldsOnBoard[i].Y == y)
                    return false;
            }*/

            foreach(AvaibleFields field in availbleFieldsOnBoard)
            {
                if (field.X == x && field.Y == y)
                    return ColisionDetect.NoCollision;
            }

            return true;

            /*if (y == leftCorner) //górna sciana
                return true;
            if (x == topCorner) //lewa sciana
                return true;
            if (y == height - 1 + leftCorner) //dolna sciana
                return true;
            if (x == width - 1 + topCorner) //prawa sciana
                return true;
            
            return false;*/
        }

        private void CompleteAvaibleFields()
        {
            for (int x = topCorner; x <= width + topCorner - 2; x++)
            {
                for (int y = leftCorner; y <= height + leftCorner -2; y++)
                {
                    AvaibleFields avaibleFields = new AvaibleFields();
                    avaibleFields.X = x;
                    avaibleFields.Y = y;
                    avaibleFields.TypeOfObstacles = TypeOfObstacles.None;

                    availbleFieldsOnBoard.Add(avaibleFields);
                }
            }
        }

        public AvaibleFields GetRandomAvaibleField()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, availbleFieldsOnBoard.Count);

            AvaibleFields avaibleFields =  availbleFieldsOnBoard[randomNumber];

            private void GenerateRandomStoneObstacles()
            {
                int countOfStoneObstacles = (height * width) / percentOfStoneObstacles;

                Random random = new Random();
                for (int i = 0; i < countOfStoneStoneObstacles; i++)
                {
                    int randomField = random.Next(availbleFieldsOnBoard.Cout);
                        if (availbleFieldsOnBoard[i].TypeOfObstacles == TypeOfObstacles.None)
                            availbleFieldsOnBoard[i].TypeOfObstacles = TypeOfObstacles.Stone;
                }
            }

        }
    }
}
