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
    /// Логика взаимодействия для GameStart.xaml
    /// </summary>
    public partial class GameStart : Window
    {
        public string ViewModel { get; set; }
        public GameStart(string quantity)
        {
            InitializeComponent();
            Label_quantity.Content += quantity;
        } 
        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
        public static byte AmountOfPlayers1 { get; set; }
    }
}
