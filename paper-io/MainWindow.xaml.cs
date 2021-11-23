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
        }
    }
}

class Game
{
    private Player[,] players; //Кол-во игроков

    public Game(int Players)
    {
        players = new Player[Players * 10, Players * 10];
    }
}

class Player
{
    private int x; //где?
    private int y; //где №2?
    private bool life; //Сдох?
    private Color colorOfPlayer; //Негр?

    public Player(int X, int Y, bool Life, Color color)
    {
        x = X;
        y = Y;
        life = Life;
        colorOfPlayer = color;
    }
}
