using System.Windows.Media;

namespace paper_io
{
    class Player
    {
        private int x; //где?
        private int y; //где №2?
        private bool life; //Сдох?
        private Color colorOfPlayer; //Негр?
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
