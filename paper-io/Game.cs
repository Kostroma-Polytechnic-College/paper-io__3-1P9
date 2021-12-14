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
        /// Матрица игрового поля.
        /// </summary>
        public Player[,] GameMatrix;
        /// <summary>
        /// Перечисление игрокоов.
        /// </summary>
        List<Player> players = new List<Player>();
        /// <summary>
        /// Конструктор генерации поля игры
        /// </summary>
        /// <param name="players">Количество игроков</param>
        public Game(int players)
        {
            GameMatrix = new Player[players * 10, players * 10];
            for (int i = 0; i < players; i++)
            {
                Point point = FindPoint();
                if (point.X == -1 || point.Y == -1)
                    throw new Exception("Нет свободног места, для создания игрока!");
                SpawnPlayer(point, new Player());
            }
        }
        /// <summary>
        /// Находит координаты свободной матрицы
        /// </summary>
        public Point FindPoint()
        {
            List<Point> locations = new List<Point>();
            for (int originalline = 0; originalline < GameMatrix.GetLength(0) - 2; originalline++)
            {
                for (int column = 0; column < GameMatrix.GetLength(0) - 2; column++)
                {
                    if (CheckPoint(originalline, column))
                    {
                        locations.Add(new Point(originalline, column));
                    }
                }
            }
            if (locations.Count() != 0)
            {
                Random random = new Random();
                return locations[random.Next(locations.Count())];
            }
            return new Point(-1, -1);
        }
        /// <summary>
        /// Проводит проверку вхождения матрицы 3 на 3, начиная с верхнего левого угла.
        /// </summary>
        /// <returns>bool</returns>
        private bool CheckPoint(int line, int column)
        {
            for (int l = line; l < line + 3; l++)
            {
                for (int c = column; c < column + 3; c++)
                {
                    if (GameMatrix[l, c] != null) return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Создаёт область игрока
        /// </summary>
        /// <param name="point">Левая верхняя точка матрицы 3 на 3.</param>
        private void SpawnPlayer(Point point, Player player)
        {
            player.Location = new Point(point.X + 1, point.Y + 1);
            for (int i = (int)point.X; i < point.X + 3; i++)
            {
                for (int j = (int)point.Y; j < (int)point.Y + 3; j++)
                {
                    GameMatrix[i, j] = player;
                }
            }
        }
    }
}