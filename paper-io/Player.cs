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
    }
}
