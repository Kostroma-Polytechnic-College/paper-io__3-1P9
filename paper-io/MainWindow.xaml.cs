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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Game game = new Game(6);
            game.StartGame();
        }
    }
    public class Game
    {
        private Player[,] gamematrix; //Кол-во игроков
        int heightmatrix;
        public Game(int players)
        {
            heightmatrix = players * 10;
            gamematrix = new Player[heightmatrix, heightmatrix];
        }
        /// <summary>
        /// Создает матрицу 3 на 3 с игроком в центре.
        /// </summary>
        public void StartGame()
        {
            //int[строка , столбец]
            List<Coordinate> coordinates = new List<Coordinate>();
            for (int originalline = 0; originalline < heightmatrix - 2; originalline++)
            { 
                for(int column = 0; column < heightmatrix; column++)
                {
                    if (ChekPoint(originalline, column))
                    {
                        coordinates.Add(new Coordinate(originalline, column));
                    }
                } 
            }
            if (coordinates.Count() != 0) 
            {
                Random random = new Random();
                Coordinate coordinate = coordinates[random.Next(0, coordinates.Count() - 1)];

                CreatePlayer(coordinate); 
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
                for(int l = line; l < line + 3; l++)
                {
                    for(int c = column; c < column + 3; c++)
                    {
                        if (gamematrix[l, c] != null) return (false);
                    }
                }
                return (true);
            }
            catch
            {
                return (false);
            }
        }
        /// <summary>
        /// Создает игрока в подматрице 3 на 3 в центре и с тереторией в подматрицу, начиная с верхнего левого угла.
        /// </summary>
        /// <param name="coordinate"></param>
        private void CreatePlayer(Coordinate coordinate)
        {
            Player player = new Player(new Coordinate(coordinate.X + 1, coordinate.Y + 1));
            for(int i = coordinate.X; i < coordinate.X + 3; i++)
            {
                for(int j = coordinate.Y; j < coordinate.Y + 3; j++)
                {
                    gamematrix[i, j] = player;
                }
            }
        }
    }
    public class Player
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
    public class Coordinate
    {
        private int x;
        private int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinate() { }
        public int X
        {
            get { return (x); }
            set { x = value; }
        }
        public int Y
        {
            get { return (y); }
            set { x = value; }
        }
    }
}
