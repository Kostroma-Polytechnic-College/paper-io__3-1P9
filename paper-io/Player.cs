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
            int x = (int) Location.X;
            int y = (int) Location.Y;

            /* Если со всех сторон находится территория текущего игрока, то направление 
               движения не менять*/
            if (players[x, y + 1] == this
                && players[x - 1, y] == this
                && players[x + 1, y] == this
                && players[x, y - 1] == this
                )
            {
                return;
            }

            /* Если впереди текущего игрока находится стена и слева нет стены, то повернуть налево. */
            if (y > 0) { 
                if (x == 0 || x == players.Length - 1)
                {
                    PlayerDirection = Direction.Left;
                    return;
                }
            }

            /*  Если впереди игрока находится стена и справа нет стены, то повернуть направо. */
            if (y < players.Length - 1)
            {
                if (x == 0 || x == players.Length - 1)
                {
                    PlayerDirection = Direction.Right;
                    return;
                }
            }

            /* Если впереди и слева и справа нет территории текущего игрока, то повернуть
               направо если там нет стены или повернуть налево если справа есть стена. Если впереди нет территории  */
            if (players[x, y + 1] == this
                && players[x - 1, y] == this
                && players[x + 1, y] == this
                )
            {
                if (x != 0 || y < players.Length - 1)
                {
                    PlayerDirection = Direction.Right;
                    return;
                }

                PlayerDirection = Direction.Left;
            }
        }
    }
}
