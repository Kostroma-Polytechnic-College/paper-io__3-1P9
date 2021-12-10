using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace paper_io
{
    /// <summary>
    /// Основной класс, использьзуется для создания поля и отслеживания количества игроков
    /// </summary>
    class Game
    {
        /// <summary>
        /// Список всех игроков
        /// </summary>
        List<Player> Players = new List<Player>();
        /// <summary>
        /// Матрица игрового поля. Хранит территорию игроков
        /// </summary>
        public Player[,] gameMatrix;
        public Game(int players)
        {
            gameMatrix = new Player[players * 10, players * 10];
            for (int i = 0; i < players; i++) FindePoint();
        }
        /// <summary>
        /// Ищет сектор 3 на 3 и если он есть, то вызывает метод CreatePlayer.
        /// </summary>
        public void FindePoint()
        {
            List<Point> locations = new List<Point>();
            for (int originalline = 0; originalline < gameMatrix.GetLength(0) - 2; originalline++)
            {
                for (int column = 0; column < gameMatrix.GetLength(0) - 2; column++)
                {
                    if (ChekPoint(originalline, column))
                    {
                        locations.Add(new Point(originalline, column));
                    }
                }
            }
            if (locations.Count() != 0)
            {
                Random random = new Random();
                Point location = locations[random.Next(locations.Count())];

                CreatePlayer(location);
            }
        }
        /// <summary>
        /// Проверяет, входит ли подматрица 3 на 3 в главную матрицу игры, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="line">Координата X</param>
        /// <param name="column">Координата Y</param>
        /// <returns>bool</returns>
        private bool ChekPoint(int line, int column)
        {
            for (int l = line; l < line + 3; l++)
            {
                for (int c = column; c < column + 3; c++)
                {
                    if (gameMatrix[l, c] != null) return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Принимает количество игроков и делает поле размерностью n*n, где n- количество игроков * 10
        /// </summary>
        /// <param name="n">Количество игроков</param>
        private void CreatePlayer(Point point)
        {
            Player player = new Player(new Point(point.X + 1, point.Y + 1));
            Players.Add(player);
            for (int i = (int)point.X; i < point.X + 3; i++)
            {
                for (int j = (int)point.Y; j < (int)point.Y + 3; j++)
                {
                    gameMatrix[i, j] = player;
                }
            }
        }
    }
}