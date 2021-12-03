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
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для GameLauncher.xaml
    /// </summary>
    public partial class GameLauncher : Window
    {
        public GameLauncher()
        {
            InitializeComponent();
            Grid grid = (Grid)PoleGrid;
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            

            int adsa = Game.AmountOfPlayers;
            for (int i = 0; i < adsa; i++)
            {

            }
        }
    }
}
