using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;

namespace Dictonary
{
    public static class EnglishDictonary
    {
        public static void Init() { }

        static EnglishDictonary()
        {
            if (!Directory.Exists(PathToAppFolder))
            {
                Directory.CreateDirectory(PathToAppFolder);
            }

            if (!File.Exists(PathToWordsFile))
            {
                File.Create(PathToWordsFile);
            }
        }

        public static void AddWord(string entry)
        {
            StreamWriter wr = File.AppendText(PathToWordsFile);
            wr.WriteLine(entry);
            wr.Close();
        }

        public static List<string> GetAllEnglishWords()
        {
            List<string> englishWords = new List<string>();

            StreamReader streamReader = new StreamReader(PathToWordsFile);

            while (!streamReader.EndOfStream)
            {
                englishWords.Add(GetEnglishWordFromLine(streamReader.ReadLine()));
            }

            streamReader.Close();

            return englishWords;
        }

        public static string GetTranslateWord(string englishWord)
        {
            string translateWord = null;

            StreamReader streamReader = new StreamReader(PathToWordsFile);

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();

                if (GetEnglishWordFromLine(line) == englishWord)
                {
                    string findLine = line;
                    int equalIndex = 0;

                    foreach (char symbol in findLine)
                    {
                        equalIndex++;

                        if (symbol == '=')
                            break;
                    }

                    for (int i = equalIndex; i < findLine.Length; i++)
                    {
                        translateWord += findLine[i];
                    }
                }
            }

            streamReader.Close();

            return translateWord;
        }

        public static void DeleteWord(string englishWord)
        {
            List<string> words = new List<string>();

            StreamReader streamReader = new StreamReader(PathToWordsFile);

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();

                if(GetEnglishWordFromLine(line) != englishWord)
                {
                    words.Add(line);
                }
            }

            streamReader.Close();

            File.WriteAllText(PathToWordsFile, string.Empty);
            StreamWriter wr = File.AppendText(PathToWordsFile);

            foreach (string line in words)
            {
                wr.WriteLine(line);
            }

            wr.Close();
        }

        private static string GetEnglishWordFromLine(string line)
        {
            string englishWord = null;

            foreach (char symbol in line)
            {
                if (symbol == '=')
                    break;
                else
                    englishWord += symbol;
            }

            return englishWord;
        }

        public static string PathToAppData = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming";
        private static string PathToAppFolder = PathToAppData + "\\Dictonary";
        private static string PathToWordsFile = PathToAppData + "\\Dictonary\\Words.txt";
    }
}
