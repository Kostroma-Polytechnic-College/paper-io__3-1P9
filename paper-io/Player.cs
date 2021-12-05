using System.Windows;
using System.Windows.Media;

namespace paper_io
{
    /// <summary>
    /// Класс игрока
    /// </summary>
    class Player
    {
        /// <summary>
        /// Жизнь игрока
        /// </summary>
        private bool life;
        /// <summary>
        /// Координаты игрока.
        /// </summary>
        private Point point;
        /// <summary>
        /// Цвет игрока.
        /// </summary>
        private Color ColorOfPlayer { get; set; }

        public Player(Point coordinate)
        {
            point = coordinate;
            life = true;
        }
        public int X
        {
            get
            {
                return (int)point.X;
            }
        }
        public int Y
        {
            get
            {
                return (int)point.Y;
            }
        }
    }
}
