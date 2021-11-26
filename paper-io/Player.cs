using System.Windows.Media;

namespace paper_io
{
    class Player
    {
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

        public Player(Coordinate сoordinate, bool Life, Color color)
        {
            x = сoordinate.X;
            y = сoordinate.Y;
            life = Life;
            colorOfPlayer = color;
        }
        public Player(Coordinate coordinate)
        {
            x = coordinate.X;
            y = coordinate.Y;
        }
    }
}
