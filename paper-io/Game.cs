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
        /// Матрица игроков
        /// </summary>
        public Player[,] MatrixOfPlayers { get; set; }

        /// <summary>
        /// Количество игроков
        /// </summary>
        public static int AmoutOfPlayers { get; set; }
        public Game(int players)
        {
            AmoutOfPlayers = players;
            MatrixOfPlayers = new Player[players * 10, players * 10];

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
