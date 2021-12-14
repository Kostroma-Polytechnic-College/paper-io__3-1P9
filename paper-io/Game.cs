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
        public Player[,] Gamematrix;
        List<Player> players = new List<Player>();
        /// <summary>
        /// Конструктор генерации поля игры
        /// </summary>
        /// <param name="players">Количество игроков</param>
        public Game(int players)
        {
            Gamematrix = new Player[players * 10, players * 10];
            for (int i = 0; i < players; i++) FindePoint();
        }
        /// <summary>
        /// Находит координаты свободной матрицы
        /// </summary>
        public void FindePoint()
        {
            List<Point> locations = new List<Point>();
            for (int originalline = 0; originalline < Gamematrix.GetLength(0) - 2; originalline++)
            {
                for (int column = 0; column < Gamematrix.GetLength(0) - 2; column++)
                {
                    if (ChekPoint(new Point(originalline, column)))
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
        /// Проводит проверку вхождения матрицы 3 на 3, начиная с верхнего левого угла.
        /// </summary>
        /// <returns>bool</returns>
        private bool ChekPoint(Point point)
        {
            for (int l = (int)point.X; l < (int)point.X + 3; l++)
            {
                for (int c = (int)point.Y; c < (int)point.Y + 3; c++)
                {
                    if (Gamematrix[l, c] != null) return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Создаёт область игрока
        /// </summary>
        /// <param name="point">Левая верхняя точка матрицы 3 на 3.</param>
        private void CreatePlayer(Point point)
        {
            Player player = new Player(new Point(point.X + 1, point.Y + 1));
            players.Add(player);
            for (int i = (int)point.X; i < point.X + 3; i++)
            {
                for (int j = (int)point.Y; j < (int)point.Y + 3; j++)
                {
                    Gamematrix[i, j] = player;
                }
            }
        }
    }
}