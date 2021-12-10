using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace paper_io
{
    public class Game
    {
        /// <summary>
        /// Кол-во игроков
        /// </summary>
        private Player[,] gamematrix; 
        int heightmatrix;

        public Game(int players)
        {
            heightmatrix = players * 10;
            gamematrix = new Player[heightmatrix, heightmatrix];
        }
        /// <summary>
        /// Создает матрицу 3 на 3 с игроком в центре.
        /// </summary>
        public void StartGame()
        {
            List<Point> coordinates = new List<Point>();
            for (int originalline = 0; originalline < heightmatrix - 2; originalline++)
            {
                for (int column = 0; column < heightmatrix; column++)
                {
                    if (ChekPoint(originalline, column))
                    {
                        coordinates.Add(new Point(originalline, column));
                    }
                }
            }
            if (coordinates.Count() != 0)
            {
                Random random = new Random();
                Point coordinate = coordinates[random.Next(0, coordinates.Count() - 1)];

                CreatePlayer(coordinate);
            }
        }
        /// <summary>
        /// Проверяе, входит ли подматрица 3 на 3, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="column"></param>
        /// <returns>bool</returns>
        private bool ChekPoint(int line, int column)
        {
            try
            {
                for (int l = line; l < line + 3; l++)
                {
                    for (int c = column; c < column + 3; c++)
                    {
                        if (gamematrix[l, c] != null) return (false);
                    }
                }
                return (true);
            }
            catch
            {
                return (false);
            }
        }
        /// <summary>
        /// Создает игрока в подматрице 3 на 3 в центре и с тереторией в подматрицу, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="coordinate"></param>
        private void CreatePlayer(Point coordinate)
        {
            // См. реализацию у Рыбина Дениса
            return;
        }
    }
}
