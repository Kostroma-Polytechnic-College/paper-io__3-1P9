using System.Windows;
using System.Windows.Media;

namespace paper_io
{
    class Player
    {
        /// <summary>
        /// Координаты игрока. (с типом double)
        /// </summary>
        private Point point;
        /// <summary>
        /// Жив ли игрок?
        /// </summary>
        private bool life;
        /// <summary>
        /// Цвет игрока.
        /// </summary>
        private Color color;
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
