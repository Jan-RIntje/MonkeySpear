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

       public static void Interpreter(string rubric)
        {
            foreach (string word in Library.words)
            {
                if (rubric.IndexOf(word, StringComparison.OrdinalIgnoreCase) > -1){

                    int start = rubric.IndexOf(word);
                    string subword = rubric.Substring(start, word.Length);
                    int i = 0;
                    int counter = 0;
                    foreach (char a in word)
                    {

                        if (a == subword.IndexOf(subword.Substring(i, i), i))
                        {
                            counter++;
                        }
                       
                        i++;
                    }

                }
            }
        }

        public static void Interpreter(string rubric, List<string> words)
        {

            foreach (string word in words)
            {
                if (rubric.Contains(word))
                {
                    AddWordsFound(word);
                    removeWords(word);                  
                }
            }
        }

        public static void AddWordsFound(string word)
        {
            Library.wordsFound.Add(word);
        }

        public static void removeWords(string word)
        {
            Library.words.Add(word);
        }
    }

        static Random _random = new Random();

        public static char GetLetter()
        {
            int number = _random.Next(0, 26);
            char letter = (char)('a' + number);
            return letter;
        }
    }
}
