using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для GameStart.xaml
    /// </summary>
    public partial class GameStart : Window
    {
        public GameStart(int amount)
        {
            InitializeComponent();
            game = new Game(amount);
            game.GetPlayer.GetKeyPress += GetPlayerGetKeyPress;
        }

        private void GetPlayerGetKeyPress(Player p)
        {
            if (p.Direction == Direction.Up && direction == Direction.Down | p.Direction == Direction.Down && direction == Direction.Up | p.Direction == Direction.Left && direction == Direction.Right | p.Direction == Direction.Right && direction == Direction.Left)
            {
                return; 
            }
            p.Direction = direction;
        }

        Direction direction;
        Game game;
        private void WindowKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case (Key.Up):
                    direction = Direction.Up;
                    break;
                case (Key.Right):
                    direction = Direction.Right;
                    break;
                case (Key.Down):
                    direction = Direction.Down;
                    break;
                case (Key.Left):
                    direction = Direction.Left;
                    break;
                default:
                    break;
            }
        }
    }
}
