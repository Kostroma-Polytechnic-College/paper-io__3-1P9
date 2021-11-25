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
            Player player = new Player(0, 0, Color.FromArgb(220, 220, 220, 220));


        }
        private void StartButton(object sender, RoutedEventArgs e)
        {
            Game game = new Game(Convert.ToByte(EnterField.Text));


            //for (int i = 0; i < game.players.GetLength(0); i++)
            //{
            //    for (int j = 0; j < game.players.GetLength(1); j++)
            //    {
            //        MessageBox.Show(Convert.ToString(game.players[i, j]));
            //    }
            //}
        }
        private void EnterField_TextChanged(object sender, TextChangedEventArgs e)
        {
            string result = "";
            foreach (char item in EnterField.Text)
            {
                if (char.IsNumber(item))
                    result += item;
            }
            EnterField.Text = result;
        }
    }

    class Game
    {
        /// <summary>
        /// Количество игроков
        /// </summary>
        public Player[,] Players { get; set; }
        public Game(byte players)
        {
            Players = new Player[players * 10, players * 10];
        }
    }

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
