using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace paper_io
{ 
    public class Game
    {
        /// <summary>
        /// Матрица игрового поля.
        /// </summary>
        private Player[,] gamematrix;
        /// <summary>
        /// Перечисление игрокоов.
        /// </summary>
        List<Player> players = new List<Player>();
        public Game(int players)
        {
            gamematrix = new Player[players * 10, players * 10];
            for (int i = 0; i < players; i++) FindePoint();
        }
        /// <summary>
        /// Ищет сектор 3 на 3 и если он есть, то вызывает метод CreatePlayer.
        /// </summary>
        public void FindePoint()
        {
            List<Point> locations = new List<Point>();
            for (int originalline = 0; originalline < gamematrix.GetLength(0) - 2; originalline++)
            {
                for (int column = 0; column < gamematrix.GetLength(0) - 2; column++)
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
                    if (gamematrix[l, c] != null) return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Создает игрока в подматрице 3 на 3 в центре и с тереторией в подматрицу, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="point">Правая верхняя точка матрицы 3 на 3.</param>
        private void CreatePlayer(Point point)
        {
            Player player = new Player(new Point(point.X + 1, point.Y + 1));
            players.Add(player);
            for (int i = (int)point.X; i < point.X + 3; i++)
            {
                for (int j = (int)point.Y; j < (int)point.Y + 3; j++)
                {
                    gamematrix[i, j] = player;
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий игровую область 31 на 17 по указанным координатам
        /// </summary>
        /// <param name="point">Координаты центра искомой области</param>
        /// <returns>Игровая область 31 на 17 - двумерный массив игроков</returns>
        private Player[,] GetGameField(Point point)
        {
            Player[,] field = new Player[31, 17];

            // Координаты верхнего левого угла области отрисовки
            // Проверка на валидность координат не проводится, т.к в задании указана строгая формула
            Point topLeft = new Point(point.X - 8, point.Y - 15);

            // Перебор ячеек от рассчитанной координаты с количеством итераций 31 и 17
            // Внешние переменные для хранения индексов для возвращаемой матрицы
            int x = 0;
            int y = 0;
            for (int i = (int)topLeft.X; i < (int)topLeft.X + 31; i++)
            {
                
                for (int j = (int)topLeft.Y; i < (int)topLeft.Y + 17; i++)
                {
                    field[x, y] = gamematrix[i, j];
                    y++;
                }
                x++;
            }

            return field;
        }

    }
}
