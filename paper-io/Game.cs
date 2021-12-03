using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
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
=======
using System.Windows;

namespace paper_io
{ 
    public class Game
    {
        /// <summary>
        /// Матрица игрового поля.
        /// </summary>
        private Player[,] gamematrix;
        /// <summary>
        /// Перечисление игрокоов.
        /// </summary>
        List<Player> players = new List<Player>();
        public Game(int players)
        {
            gamematrix = new Player[players * 10, players * 10];
        }
        /// <summary>
        /// Создает матрицу 3 на 3 с игроком в центре.
        /// </summary>
        public void StartGame()
        {
            List<Point> locations = new List<Point>();
            for (int originalline = 0; originalline < gamematrix.GetLength(0) - 2; originalline++)
            {
                for (int column = 0; column < gamematrix.GetLength(0) - 2; column++)
                {
                    if (ChekPoint(originalline, column))
                    {
                        locations.Add(new Point(originalline, column));
                    }
                }
            }
            if (locations.Count() != 0)
            {
                Random random = new Random();
                Point location = locations[random.Next(locations.Count())];

                CreatePlayer(location);
            }
        }
        /// <summary>
        /// Проверяе, входит ли подматрица 3 на 3, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="column"></param>
        /// <returns>bool</returns>
        private bool ChekPoint(int line, int column)
        {
            try
            {
                for (int l = line; l < line + 3; l++)
                {
                    for (int c = column; c < column + 3; c++)
                    {
                        if (gamematrix[l, c] != null) return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Создает игрока в подматрице 3 на 3 в центре и с тереторией в подматрицу, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="location"></param>
        private void CreatePlayer(Point location)
        {
            Player player = new Player(new Point(location.X + 1, location.Y + 1));
            players.Add(player);
            for (int i = (int)location.X; i < location.X + 3; i++)
            {
                for (int j = Convert.ToInt32(location.Y); j < Convert.ToInt32(location.Y) + 3; j++)
                {
                    gamematrix[i, j] = player;
>>>>>>> a174c71fdc667ef792d2f698405bcc72acd19c23
                }
            }
        }
    }
}
