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
        public Player()
        {
            life = true;
        }

        /// <summary>
        /// Метод, отвечающий за изменение направления движения игрока/бота
        /// </summary>
        /// <param name="field">Игровое поле</param>
        /// <returns>Истина, если направление изменилось</returns>
        public bool Bot(Player[,] field)
        {
            int x = (int)Location.X;
            int y = (int)Location.Y;

            return СheckAllSides(field, x, y)
                || СheckForwardLeft(field, x, y)
                || СheckForwardRight(field, x, y)
                || СheckForwardLeftRight(field, x, y);
        }

        /// <summary>
        /// Если впереди и слева и справа нет территории текущего игрока, то повернуть
        /// направо если там нет стены или повернуть налево если справа есть стена.Если впереди нет территории
        /// </summary>
        /// <param name="field">Игровое поле</param>
        /// <param name="x">Настоящее положение игрока по оси X</param>
        /// <param name="y">Настоящее положение игрока по оси Y</param>
        /// <returns>Истина, если направление изменилось</returns>
        bool СheckForwardLeftRight(Player[,] field, int x, int y)
        {
            if (field[x, y + 1] == this
                && field[x - 1, y] == this
                && field[x + 1, y] == this
                )
            {
                if (x != 0 || y < field.Length - 1)
                {
                    TurnRight();
                    return true;
                }

                TurnLeft();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Если впереди игрока находится стена и справа нет стены, то повернуть направо.
        /// </summary>
        /// <param name="field">Игровое поле</param>
        /// <param name="x">Настоящее положение игрока по оси X</param>
        /// <param name="y">Настоящее положение игрока по оси Y</param>
        /// <returns>Истина, если направление изменилось</returns>
        bool СheckForwardRight(Player[,] field, int x, int y)
        {
            if (y < field.Length - 1)
            {
                if (x == 0 || x == field.Length - 1)
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
        /// <param name="field">Игровое поле</param>
        /// <param name="x">Настоящее положение игрока по оси X</param>
        /// <param name="y">Настоящее положение игрока по оси Y</param>
        /// <returns>Истина, если направление изменилось</returns>
        bool СheckForwardLeft(Player[,] field, int x, int y)
        {
            if (y > 0)
            {
                if (x == 0 || x == field.Length - 1)
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
        /// <param name="field">Игровое поле</param>
        /// <param name="x">Настоящее положение игрока по оси X</param>
        /// <param name="y">Настоящее положение игрока по оси Y</param>
        /// <returns>Истина, если направление изменилось</returns>
        bool СheckAllSides(Player[,] field, int x, int y)
        {
            if (field[x, y + 1] == this
                && field[x - 1, y] == this
                && field[x + 1, y] == this
                && field[x, y - 1] == this
                )
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Поворот игрока налево
        /// </summary>
        void TurnLeft()
        {
            int turn = (int) Direction - 1;
            Direction = turn < 0 ? Direction.Left : (Direction) turn;
        }

        /// <summary>
        /// Поворот игрока направо
        /// </summary>
        void TurnRight()
        {
            int turn = (int) Direction + 1;
            Direction = turn > 3 ? Direction.Up : (Direction) turn;
        }
    }
}
