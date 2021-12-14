using System.Windows;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Player
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public Direction PlayerDirection;
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
                    Turn(Direction.Right);
                    return false;
                }

                Turn(Direction.Left);
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
                    Turn(Direction.Right);
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
                    Turn(Direction.Left);
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
        private void Turn(Direction turn)
        {
            // Здесь должна быть обработка исключений
            if (turn != Direction.Right || turn != Direction.Left)
            {
                return;
            }

            switch(PlayerDirection)
            {
                case Direction.Up:
                    PlayerDirection = turn == Direction.Right ? Direction.Right : Direction.Left;
                break;
                case Direction.Right:
                    PlayerDirection = turn == Direction.Right ? Direction.Down : Direction.Up;
                    break;
                case Direction.Down:
                    PlayerDirection = turn == Direction.Right ? Direction.Left : Direction.Right;
                    break;
                case Direction.Left:
                    PlayerDirection = turn == Direction.Right ? Direction.Up : Direction.Down;
                    break;
                default:
                    break;
            }
        }
    }
}
