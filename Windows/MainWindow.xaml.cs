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
using System.IO;

namespace Dictonary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContexMenuForListBox.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint;
            ContexMenuForListBox.HorizontalOffset = 0;
            ContexMenuForListBox.VerticalOffset = 0;
            EnglishDictonary.Init();

            ShowAllWords();
        }

        private void ShowAllWords()
        {
            ListBoxAllWords.Items.Clear();
            List<string> englishWords = EnglishDictonary.GetAllEnglishWords();

            foreach (string word in englishWords)
            {
                if (word.Contains(TextBoxWordForSearch.Text))
                {
                    ListBoxAllWords.Items.Add(word);
                }
            }
        }

        private void TextBoxWordForSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            ListBoxAllWords.Items.Clear();
            List<string> englishWords = null;

            if (String.IsNullOrEmpty(TextBoxWordForSearch.Text))
            {
                ShowAllWords();
            }
            else
            {
                englishWords = EnglishDictonary.GetAllEnglishWords();

                foreach (string word in englishWords)
                {
                    if (word.Contains(TextBoxWordForSearch.Text))
                    {
                        ListBoxAllWords.Items.Add(word);
                    }
                }
            }
        }

        private void ContextMenuItemTranslateClick(object sender, RoutedEventArgs e)
        {
            string selectedWord = ListBoxAllWords.SelectedItem.ToString();
            TextBoxTranslatingWord.Text = EnglishDictonary.GetTranslateWord(selectedWord);
        }

        private void ContextMenuItemDeleteWordClick(object sender, RoutedEventArgs e)
        {
        }

        private void ListBoxAllWordsMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string selectedWord = ListBoxAllWords.SelectedItem.ToString();
            TextBoxTranslatingWord.Text = EnglishDictonary.GetTranslateWord(selectedWord);
        }

        private void ButtonClearTextBoxSearchingClick(object sender, RoutedEventArgs e)
        {
            TextBoxWordForSearch.Text = "";
        }

        private void ButtonClearTextBoxTranslateWordClick(object sender, RoutedEventArgs e)
        {
            TextBoxTranslatingWord.Text = "";
        }

        private void ListBoxAllWordsKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Delete)
            {
                string selectedWord = ListBoxAllWords.SelectedItem.ToString();
                EnglishDictonary.DeleteWord(selectedWord);
                ShowAllWords();
            }
        }

        private void ButtonAddWordClick(object sender, RoutedEventArgs e)
        {
            Dictonary.Windows.WindowAddWord windowAddWord = new Windows.WindowAddWord();
            windowAddWord.ShowDialog();
            ShowAllWords();
        }
    }
}
