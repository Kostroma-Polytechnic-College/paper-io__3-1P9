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

        public Player(int x, int y /*Color color*/)
        {
            X = x;
            Y = y;
            //ColorOfPlayer = color;
        }
    }
}
