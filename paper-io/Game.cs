using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace paper_io
{
    /// <summary>
    /// Основной класс, использьзуется для создания поля и отслеживания количества игроков
    /// </summary>
    class Game
    {
        /// <summary>
        /// Список всех игроков
        /// </summary>
        public Player[] Players;
        /// <summary>
        /// Матрица игрового поля. Хранит территорию игроков
        /// </summary>
        public Player[,] gameMatrix;
        /// <summary>
        /// Свойство для указания количества игроков 
        /// </summary>
        public static byte AmountOfPlayers { get; set; }
        /// <summary>
        /// Принимает количество игроков и делает поле размерностью n*n, где n- количество игроков * 10
        /// </summary>
        /// <param name="n">Количество игроков</param>
        public Game(byte n)
        {
            Players = new Player[n];
            gameMatrix = new Player[n * 10, n * 10];
        }
    }
}
