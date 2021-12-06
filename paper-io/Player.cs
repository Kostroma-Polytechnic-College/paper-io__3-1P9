using System.Windows;
using System.Windows.Media;

namespace paper_io
{
    class Player
    {
        /// <summary>
        /// Координаты игрока. (с типом double)
        /// </summary>
        private Point location;
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
            location = coordinate;
            life = true;
        }
        public int X
        {
            get
            {
                return (int)location.X;
            }
        }
        public int Y
        {
            get
            {
                return (int)location.Y;
            }
        }
    }
}
