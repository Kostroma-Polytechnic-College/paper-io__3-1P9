using System;
using System.Windows.Media;

namespace paper_io
{
    class Player
    {
        /// <summary>
        /// Координаты игрока
        /// </summary>
        private int x;
        private int y; 
        /// <summary>
        /// Жив ли / мертв ли игрок 
        /// </summary>
        private bool life; 
        private Color colorOfPlayer;
        /// <summary>
        /// Направление движения игрока
        /// </summary>
        private PlayerDirection direction; 
        /// <summary>
        /// Бот / игрок
        /// </summary>
        private bool isBot;


        public Player(Coordinate сoordinate, bool Life, Color color)
        {
            x = сoordinate.X;
            y = сoordinate.Y;
            life = Life;
            colorOfPlayer = color;

            // Изначально игрок идет вправо (просто потому что)
            direction = PlayerDirection.Right;
        }

        public Player(Coordinate coordinate)
        {
            x = coordinate.X;
            y = coordinate.Y;

            // Изначально игрок идет вправо (просто потому что)
            direction = PlayerDirection.Right;
        }

        /// <summary>
        /// Метод, отвечающий за изменение направления движения игрока/бота
        /// </summary>
        /// <param name="gamematrix"></param>
        public void ChangeDirection(Player[,] gamematrix)
        {
            // Проход по всем клеткам игрового поля
            foreach (var row in gamematrix)
            {
                // По всей видимости, я не понимаю, что содержит внутри себя gamematrix типа Player[,]
                // Ошибка: Player не содержит открытое определение экземпляра или расширения для типа "GetEnumerator"
                // foreach (var column in row)
                
                // Заглушка для ошибки, описанной выше
                foreach (var column in new int[] { 1, 2, 3 })
                {
                    // Заглушка для логики выбора направления (на данный момент мне неясно, как именно устроен объект gamematrix типа Player[,])
                    // Сейчас движение меняется просто за счет случайного числа
                    var random = new Random();
                    var num = random.Next(0, 3);

                    switch(num)
                    {
                        case 0: 
                            direction = PlayerDirection.Left;
                            break;
                        case 1: 
                            direction = PlayerDirection.Down;
                            break;
                        case 2: 
                            direction = PlayerDirection.Up;
                            break;
                        case 3:
                            direction = PlayerDirection.Right;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
