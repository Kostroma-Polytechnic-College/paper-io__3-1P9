using System.Windows.Media;

namespace paper_io
{
    class Player
    {
        /// <summary>
        /// Координата расположения игрока по X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата расположения игрока по Y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Цвет игрока
        /// </summary>
        public Color ColorOfPlayer { get; set; }
        /// <summary>
        /// Жизнь игрока
        /// </summary>
        private readonly bool life = true; 

        public Player(int x, int y, Color color)
        {
            X = x;
            Y = y;
            ColorOfPlayer = color;
        }
    }
}
