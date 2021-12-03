<<<<<<< HEAD
﻿using System;
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
=======
﻿using System.Windows;
using System.Windows.Media;
>>>>>>> a174c71fdc667ef792d2f698405bcc72acd19c23

namespace paper_io
{
    class Player
    {
        /// <summary>
<<<<<<< HEAD
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
=======
        /// Координаты игрока. (с типом double)
        /// </summary>
        private Point point;
        /// <summary>
        /// Жив ли игрок?
        /// </summary>
        private bool life;
        /// <summary>
        /// Цвет игрока.
        /// </summary>
        private Color color;
        public Player(Point coordinate)
        {
            point = coordinate;
            life = true;
        }
        public int X
        {
            get
            {
                return (int)point.X;
            }
        }
        public int Y
        {
            get
            {
                return (int)point.Y;
            }
>>>>>>> a174c71fdc667ef792d2f698405bcc72acd19c23
        }
    }
}
