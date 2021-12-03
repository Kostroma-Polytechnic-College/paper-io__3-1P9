using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paper_io
{
    class Game
    {
        /// <summary>
        /// Количество игроков
        /// </summary>
        public Player[,] MatrixOfPlayers { get; set; }

        public static int AmoutOfPlayers { get; set; }
        public Game(int players)
        {
            MatrixOfPlayers = new Player[AmoutOfPlayers * 10, AmoutOfPlayers * 10];

            for (int x = 0; x < MatrixOfPlayers.GetLength(0); x++)
            {
                for (int y = 0; y < MatrixOfPlayers.GetLength(1); y++)
                {
                    MatrixOfPlayers[y, x] = new Player(y, x);
                }
            }
        }
    }
}
