using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dictonary.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddWord.xaml
    /// </summary>
    public partial class WindowAddWord : Window
    {
        public WindowAddWord()
        {
            InitializeComponent();
        }

        private void ButtonCloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonAddWordClick(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxEnglishWord.Text) || String.IsNullOrEmpty(TextBoxWordRussianWord.Text))
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            EnglishDictonary.AddWord(TextBoxEnglishWord.Text + " = " + TextBoxWordRussianWord.Text);
            MessageBox.Show("Слово добавлено", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
