using System;
using System.Windows;
using System.Windows.Media;

namespace paper_io
{
    class Player
    {
        /// <summary>
        /// Координата по оси x.
        /// </summary>
        private int x;
        /// <summary>
        /// Координата по оси y.
        /// </summary>
        private int y;
        /// <summary>
        /// Жив ли игрок?
        /// </summary>
        private bool life;
        /// <summary>
        /// Цвет игрока.
        /// </summary>
        private Color colorOfPlayer;
        public Player(Point сoordinate, bool Life = true /*, Color color - требуется функция. (не является коментарием)*/)
        {
            x = Convert.ToInt16(сoordinate.X);
            y = Convert.ToInt16(сoordinate.Y);
            life = Life;
            //colorOfPlayer = color; - требуется функция. (не является коментарием)
        }
    }
}
