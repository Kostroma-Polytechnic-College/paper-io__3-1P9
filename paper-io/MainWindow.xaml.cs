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

        /// <summary>
        /// Запуск игры 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton(object sender, RoutedEventArgs e)
        {
            string quantity = EnterField.Text;
            int amount = int.Parse(quantity);
            this.Hide();
            new GameStart(amount).ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Поле ввода количества игроков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterField_TextChanged(object sender, TextChangedEventArgs e)
        {
            string result = "";
            foreach (char item in EnterField.Text)
            {
                if (char.IsNumber(item))
                    result += item;
            }
            EnterField.Text = result;
        }
    }
}
