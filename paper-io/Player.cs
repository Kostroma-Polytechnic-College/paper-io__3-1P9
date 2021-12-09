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
        public Player()
        {
        }
    }
}
