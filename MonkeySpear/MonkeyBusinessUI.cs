using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyBusinessLibrary;

namespace MonkeySpear
{
    public static class MonkeyBusinessUI
    {
       public static MonkeyLibrary Library = new MonkeyLibrary();


        public static void Interpreter(string rubric, List<string> words)
        {

            foreach (string word in words)
            {
                if (rubric.Contains(word))
                {
                    AddWordsFound(word);
                   // RemoveWords(word);                  
                }
            }
        }

        public static void AddWordsFound(string word)
        {
            Library.wordsFound.Add(word);
        }

        public static void RemoveWords(string word)
        {
            Library.words.Remove(word);
        }


        static Random _random = new Random();

        public static char GetLetter()
        {
            int number = _random.Next(0, 26);
            char letter = (char)('a' + number);
            return letter;
        }

        public static string Randomizer()
        {
            while (Form1.output.Length < 100)
            {
                Form1.output = Form1.output + GetLetter();
                
            }
            return Form1.output;

        }
    }

    }

