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
        private double percentOfStoneObstacles = 0.06;
        private char StoneChar = 'S';

        private ConsoleColor borderBackGrounColor = ConsoleColor.DarkRed;
        private ConsoleColor borderForegroundColor = ConsoleColor.DarkYellow;

        private ConsoleColor stoneBackGroundColor = ConsoleColor.DarkGreen;
        private ConsoleColor stoneForegroundColor = ConsoleColor.Gray;

        private char borderChar = 'X';

        private List<AvaibleFields> availbleFieldsOnBoard = new List<AvaibleFields>();

        public Board()
        {
            
        }

        public void Draw()
        {
            Console.Clear();

            Console.ForegroundColor = borderForegroundColor;
            Console.BackgroundColor = borderBackGrounColor;

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
            Console.ForegroundColor = stoneForegroundColor;
            Console.BackgroundColor = stoneBackGroundColor;

            List<AvaibleFields> listOfStone = availbleFieldsOnBoard.Where(af => af.TypeOfObstacles == TypeOfObstacles.Stone).ToList();
            foreach(AvaibleFields item in listOfStone)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(StoneChar);
            }
            Console.ResetColor();
        }

        public ColisionType CollisionDetect(int x, int y)
        {
           /* for (int i = 0; i < availbleFieldsOnBoard.Count; i++)
            {
                if (availbleFieldsOnBoard[i].X == x && availbleFieldsOnBoard[i].Y == y)
                    return false;
            }*/

            foreach(AvaibleFields field in availbleFieldsOnBoard)
            {
                if (field.X == x && field.Y == y)
                    return ColisionType.NoCollision;
            }

            return ColisionType.BorderCollision;

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

        private void GenerateRandomStoneObstacles()
        {
            int countOfStoneObstacles = (int)(height * width * percentOfStoneObstacles);

            Random random = new Random();
            for (int i = 0; i < countOfStoneObstacles; i++)
            {
                int randomField = random.Next(availbleFieldsOnBoard.Count);
                if (availbleFieldsOnBoard[i].TypeOfObstacles == TypeOfObstacles.None)
                    availbleFieldsOnBoard[i].TypeOfObstacles = TypeOfObstacles.Stone;
            }
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
    }

    public AvailableField GetRandomAvailableField()
    {
        Random random = new Random();

        int randomNumber = random.Next(0, avaibleFieldsOnBoard.Count);
    }
}
