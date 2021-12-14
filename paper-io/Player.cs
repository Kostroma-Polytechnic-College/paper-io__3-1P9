using System.Windows;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    /// <summary>
    /// Перечисление возможного направления игрока
    /// </summary>
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    }

    class Player
    {
        public Direction Direction;
        /// <summary>
        /// Координаты игрока. (с типом double)
        /// </summary>
        public Point Location;
        /// <summary>
        /// Жив ли игрок?
        /// </summary>
        private bool life;
        /// <summary>
        /// Цвет игрока.
        /// </summary>
        private Color color;
        /// <summary>
        /// Конструктор игрока.
        /// </summary>
        /// <param name="point">Точка, по координатам которой появится игрок.</param>
        public Player(Point point)
        {
            Location = point;
            life = true;
        }

        /// <summary>
        /// Метод, отвечающий за изменение направления движения игрока/бота
        /// </summary>
        /// <param name="gamematrix"></param>
        public void Bot(Player[,] players)
        {
            int x = (int)Location.X;
            int y = (int)Location.Y;

            if (!checkAllSides(players, x, y)
                || !checkForwardLeft(players, x, y)
                || !checkForwardRight(players, x, y)
                || !checkForwardLeftRight(players, x, y))
            {
                return;
            }
        }

        /// <summary>
        /// Если впереди и слева и справа нет территории текущего игрока, то повернуть
        /// направо если там нет стены или повернуть налево если справа есть стена.Если впереди нет территории
        /// </summary>
        /// <param name="players"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private bool checkForwardLeftRight(Player[,] players, int x, int y)
        {
            if (players[x, y + 1] == this
                && players[x - 1, y] == this
                && players[x + 1, y] == this
                )
            {
                if (x != 0 || y < players.Length - 1)
                {
                    TurnRight();
                    return false;
                }

                TurnLeft();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Если впереди игрока находится стена и справа нет стены, то повернуть направо.
        /// </summary>
        /// <param name="players"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private bool checkForwardRight(Player[,] players, int x, int y)
        {
            if (y < players.Length - 1)
            {
                if (x == 0 || x == players.Length - 1)
                {
                    TurnRight();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Если впереди текущего игрока находится стена и слева нет стены, то повернуть налево.
        /// </summary>
        /// <param name="players"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private bool checkForwardLeft(Player[,] players, int x, int y)
        {
            if (y > 0)
            {
                if (x == 0 || x == players.Length - 1)
                {
                    TurnLeft();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Если со всех сторон находится территория текущего игрока, то направление движения не менять
        /// </summary>
        /// <param name="players"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool checkAllSides(Player[,] players, int x, int y)
        {
            if (players[x, y + 1] == this
                && players[x - 1, y] == this
                && players[x + 1, y] == this
                && players[x, y - 1] == this
                )
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Поворот игрока направо
        /// </summary>
        /// <param name="players"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void TurnRight(Direction turn)
        {
            int turn = (int) Direction - 1;
            Direction = turn < 0 ? Direction.Left : (Direction) turn;
        }

        /// <summary>
        /// Поворот игрока налево
        /// </summary>
        /// <param name="players"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void TurnRight(Direction turn)
        {
            int turn = (int) Direction + 1;
            Direction = turn > 3 ? Direction.Up : (Direction) turn;
        }
    }
}
