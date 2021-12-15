using System.Windows;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Player
    {
        /// <summary>
        /// Координаты игрока. (с типом double)
        /// </summary>
        public Point Location;
        /// <summary>
        /// Жив ли игрок?
        /// </summary>
        private bool life;
        /// <summary>
        /// Цвет игрока.
        /// </summary>
        private Color color;
        /// <summary>
        /// Конструктор игрока.
        /// </summary>
        /// <param name="point">Точка, по координатам которой появится игрок.</param>
        public Player()
        {
            life = true;
        }
    }
}
