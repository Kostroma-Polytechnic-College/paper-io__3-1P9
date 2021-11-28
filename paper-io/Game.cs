namespace paper_io
{
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
}
