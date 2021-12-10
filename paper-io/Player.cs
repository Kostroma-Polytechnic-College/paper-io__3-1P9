using System;
using System.Windows;
using System.Windows.Media;

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

        /// <summary>
        /// Координаты игрока
        /// </summary>
        private int x;
        private int y; 
        /// <summary>
        /// Жив ли / мертв ли игрок 
        /// </summary>
        private bool life; 
        private Color colorOfPlayer;
        /// <summary>
        /// Направление движения игрока
        /// </summary>
        private Direction direction; 
        /// <summary>
        /// Бот / игрок
        /// </summary>
        private bool isBot;

        public Player(Point сoordinate, bool Life, Color color)
        {
            x = (int) сoordinate.X;
            y = (int) сoordinate.Y;
            life = Life;
            colorOfPlayer = color;

            // Изначально игрок идет вправо (просто потому что)
            direction = Direction.Right;
        }

        public Player(Point coordinate)
        {
            x = (int) coordinate.X;
            y = (int) coordinate.Y;

            // Изначально игрок идет вправо (просто потому что)
            direction = Direction.Right;
        }

        /// <summary>
        /// Метод, отвечающий за изменение направления движения игрока/бота
        /// </summary>
        /// <param name="gamematrix"></param>
        public void Bot(Player[,] players)
        {
            /* Если со всех сторон находится территория текущего игрока, то направление 
               движения не менять*/
            if (players[this.x, this.y + 1].GetHashCode() == this.GetHashCode()
                && players[this.x - 1, this.y].GetHashCode() == this.GetHashCode()
                && players[this.x + 1, this.y].GetHashCode() == this.GetHashCode()
                && players[this.x, this.y - 1].GetHashCode() == this.GetHashCode()
                )
            {
                return;
            }

            /* Если впереди текущего игрока находится стена и слева нет стены, то повернуть налево. */
            if (this.x == 0 && this.y > 0)
            {
                this.direction = Direction.Left;
                return;
            }

            /*  Если впереди игрока находится стена и справа нет стены, то повернуть направо. */
            if (this.x == 0 && this.y < players.Length - 1)
            {
                this.direction = Direction.Right;
                return;
            }

            /* Если впереди и слева и справа нет территории текущего игрока, то повернуть
               направо если там нет стены или повернуть налево если справа есть стена. Если впереди нет территории  */
            if (players[this.x, this.y + 1].GetHashCode() == this.GetHashCode() 
                && players[this.x - 1, this.y].GetHashCode() == this.GetHashCode()
                && players[this.x + 1, this.y].GetHashCode() == this.GetHashCode()
                )
            {
                if (this.x != 0 || this.y < players.Length - 1)
                {
                    this.direction = Direction.Right;
                } else
                {
                    this.direction = Direction.Left;
                }
            }
        }
    }
}
