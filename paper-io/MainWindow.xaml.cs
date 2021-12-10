using System;
using System.Windows;

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
        private void EnterField_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
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
